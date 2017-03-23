using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using SaleManager.Data.Models;
namespace SaleManager.App.GUI
{
    public partial class frmStaffGroups : frmBase
    {
        public frmStaffGroups()
        {
            InitializeComponent();
            //Load
            Load += (sender, e) =>
            {
                BindingGridView();
            };
            //Add button click
            ucActionButton.AddButtonClick += (sender, e) =>
            {
                frmStaffGroup frm = new frmStaffGroup();
                frm.OnSaved += t =>
                {
                    var staffGroup = (StaffGroup)t;
                    unitOfWork.StaffGroupService.Create(staffGroup);
                    unitOfWork.Save();
                    //reload gridview
                    BindingGridView();
                    frm.Close();
                };
                frm.ShowDialog();
            };
            //Edit button click
            ucActionButton.EditButtonClick += (sender, e) =>
            {
                frmStaffGroup frm = new frmStaffGroup();
                frm.staffGroup = unitOfWork.StaffGroupService.Find(staffGroupId);
                frm.OnSaved += t =>
                {
                    var staffGroup = (StaffGroup)t;
                    unitOfWork.StaffGroupService.Update(staffGroup);
                    unitOfWork.Save();
                    //reload gridview
                    BindingGridView();
                    frm.Close();
                };
                frm.ShowDialog();
            };
            //Delete button click
            ucActionButton.DeleteButtonClick += (sender, e) =>
            {
                var messageBox = MessageBox.Show("Bạn chắc chắn muốn xóa nhóm nhân viên này # : " + staffGroupId, "Thông báo", MessageBoxButtons.OKCancel);
                if (messageBox == DialogResult.OK)
                {
                    unitOfWork.StaffGroupService.Delete(staffGroupId);
                    unitOfWork.Save();
                    //reload gridview
                    BindingGridView();
                }
            };
        }

        private int staffGroupId
        {
            get
            {
                return (gvStaffGroup.GetFocusedRow() as StaffGroup).StaffGroupId;
            }
        }
        private void BindingGridView()
        {
            var staffGroups = unitOfWork.StaffGroupService.GetAll();
            gcStaffGroup.DataSource = staffGroups.ToList();
        }
    }
}
