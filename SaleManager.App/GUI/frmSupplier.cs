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
    public partial class frmSupplier : frmBase
    {
        public event SaveHandler OnSaved = t => { };

        public frmSupplier()
        {
            InitializeComponent();
            //Load
            Load += (sender, e) =>
            {
                if (supplier == null)
                    supplier = new Supplier();
            };
            //Save button click
            ucActionResultButton.SaveButtonClick += (sender, e) =>
            {
                if (dxValidationProvider.Validate())
                {
                    OnSaved(supplier);
                }
            };
            //Cancel button click
            ucActionResultButton.CancelButtonClick += (sender, e) =>
            {
                this.Close();
            };
        }

        public Supplier supplier
        {
            get
            {
                return bsSupplier.DataSource as Supplier;
            }
            set
            {
                bsSupplier.DataSource = value as object ?? typeof(Supplier);
            }
        }
    }
}
