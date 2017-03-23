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
namespace SaleManager.App.GUI
{
    public partial class frmRole : frmBase
    {
        public event SaveHandler OnSaved = t => { };
        private UnitOfWork _unitOfWork;
        public frmRole(UnitOfWork unitOfWork)
        {
            InitializeComponent();
            this._unitOfWork = unitOfWork;
            //Load
            Load += (sender, e) => 
            {
                if (Role == null)
                    Role = new Role();
            };
            //Save button click
            ucActionResultButton.SaveButtonClick += (sender, e) =>
            {
                //validate & gọi event OnSaved.
                if (dxValidationProvider.Validate())
                {
                    OnSaved(Role);
                }
            };
            //Cancel button click
            ucActionResultButton.CancelButtonClick += (sender, e) =>
            {
                this.Close();
            };
        }

        public Role Role 
        {
            get 
            {
                return bsRole.DataSource as Role;
            }
            set 
            {
                bsRole.DataSource = value as object ?? typeof(Role);
            }
        }
        public string RoleId
        {
            set
            {
                Role = this._unitOfWork.RoleService.Find(value);
            }
        }
    }
}
