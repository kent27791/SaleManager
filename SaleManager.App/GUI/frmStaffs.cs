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
    public partial class frmStaffs : frmBase
    {
        public frmStaffs()
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
                frmStaff frm = new frmStaff();
                frm.OnSaved += t => 
                {
                    var staff = (Staff)t;
                    unitOfWork.StaffService.Create(staff);
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
                frmStaff frm = new frmStaff();
                //send data
                frm.staff = unitOfWork.StaffService.Find(staffId);
                frm.OnSaved += t =>
                {
                    var staff = (Staff)t;
                    unitOfWork.StaffService.Update(staff);
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
                var messageBox = MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên này # : " + staffId, "Thông báo", MessageBoxButtons.OKCancel);
                if (messageBox == DialogResult.OK)
                {
                    unitOfWork.StaffService.Delete(staffId);
                    unitOfWork.Save();
                    //reload gridview
                    BindingGridView();
                }
            };
        }

        private int staffId
        {
            get
            {
                return (gvStaff.GetFocusedRow() as Staff).StaffId;
            }
        }
        private void BindingGridView()
        {
            var staffs = unitOfWork.StaffService.GetAll();
            gcStaff.DataSource = staffs.ToList();
        }

    }
}
