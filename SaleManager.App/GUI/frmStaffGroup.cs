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
    public partial class frmStaffGroup : frmBase
    {
        public event SaveHandler OnSaved = t => { };

        public frmStaffGroup()
        {
            InitializeComponent();
            //Load
            Load += (sender, e) =>
            {
                if (staffGroup == null)
                    staffGroup = new StaffGroup();
            };
            //Save button click
            ucActionResultButton.SaveButtonClick += (sender, e) =>
            {
                if (dxValidationProvider.Validate())
                {
                    OnSaved(staffGroup);
                }
            };
            //Cancel button click
            ucActionResultButton.CancelButtonClick += (sender, e) =>
            {
                this.Close();
            };
        }
        public StaffGroup staffGroup
        {
            get
            {
                return bsStaffGroup.DataSource as StaffGroup;
            }
            set
            {
                bsStaffGroup.DataSource = value as object ?? typeof(StaffGroup);
            }
        }
    }
}
