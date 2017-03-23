using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using SaleManager.Service.UnitOfWork;
using SaleManager.Data.Models;
using System.Collections;
namespace SaleManager.App.GUI
{
    public partial class frmRoles : Form
    {
        private UnitOfWork unitOfWork = new UnitOfWork(new SaleManagerContext());

        public frmRoles()
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
                frmRole frm = new frmRole(unitOfWork);
                frm.OnSaved += t => 
                {
                    var role = (Role)t;
                    unitOfWork.RoleService.Create(role);
                    unitOfWork.Save();
                    frm.Close();
                    //reload gridview
                    BindingGridView(role);
                };
                frm.ShowDialog();
            };
            //Edit button click
            ucActionButton.EditButtonClick += (sender, e) => 
            {
                frmRole frm = new frmRole(unitOfWork);
                //send data to dialog form.
                frm.RoleId = (gvRole.GetFocusedRow() as Role).RoleId;
                frm.OnSaved += t => 
                {
                    var role = (Role)t;
                    unitOfWork.RoleService.Update(role);
                    unitOfWork.Save();
                    frm.Close();
                    //reload gridview
                    BindingGridView(role);
                };
                frm.ShowDialog();
            };
            //Delete button click
            ucActionButton.DeleteButtonClick += (sender, e) => 
            {
                var roleId = (gvRole.GetFocusedRow() as Role).RoleId;
                var messageBox = MessageBox.Show("Bạn chắc chắn muốn xóa quyền hạn này # : " + roleId, "Thông báo", MessageBoxButtons.OKCancel);
                if (messageBox == DialogResult.OK)
                {
                    unitOfWork.RoleService.Delete(roleId);
                    unitOfWork.Save();
                    //reload gridview
                    BindingGridView();
                }
            };
        }

        private void BindingGridView(Role role = null) 
        {
            var roles = unitOfWork.RoleService.GetAll();
            gcRole.DataSource = roles.ToList();
            if (role != null)
            {
                gvRole.FocusedRowHandle = gvRole.GetRowHandle((gvRole.DataSource as IList).IndexOf(role));
            }
        }
    }
}
