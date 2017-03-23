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
    public partial class frmStaff : frmBase
    {
        public event SaveHandler OnSaved = t => { };

        public frmStaff()
        {
            InitializeComponent();
            //Load
            Load += (sender, e) => 
            {
                if (staff == null)
                    staff = new Staff();
                LoadStaffGroup();
            };
            //Save button click
            ucActionResultButton.SaveButtonClick += (sender, e) => 
            {
                if (dxValidationProvider.Validate()) 
                {
                    OnSaved(staff);
                }
            };
            //Cancel button click
            ucActionResultButton.CancelButtonClick += (sender, e) => 
            {
                this.Close();
            };
            //Add staff group button click
            btnStaffGroupAdd.Click += (sender, e) => 
            {
                frmStaffGroup frm = new frmStaffGroup();
                frm.OnSaved += t => 
                {
                    var staffGroup = (StaffGroup)t;
                    unitOfWork.StaffGroupService.Create(staffGroup);
                    unitOfWork.Save();
                    //reload combobox
                    LoadStaffGroup();
                    frm.Close();
                };
                frm.ShowDialog();
            };
        }
        private void LoadStaffGroup()
        {
            var staffGroups = unitOfWork.StaffGroupService.GetAllForCombobox();
            cbxStaffGroup.Properties.DisplayMember = "Name";
            cbxStaffGroup.Properties.ValueMember = "StaffGroupId";
            cbxStaffGroup.Properties.DataSource = staffGroups.ToList();
        }
        public Staff staff 
        {
            get 
            {
                return bsStaff.DataSource as Staff;
            }
            set 
            {
                bsStaff.DataSource = value as object ?? typeof(Staff);
            }
        }
    }
}
