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
    public partial class frmCustomer : frmBase
    {
        public event SaveHandler OnSaved = t => { };

        public frmCustomer()
        {
            InitializeComponent();
            //Load
            Load += (sender, e) =>
            {
                if (customer == null)
                    customer = new Customer();
            };
            //Save button click
            ucActionResultButton.SaveButtonClick += (sender, e) =>
            {
                if (dxValidationProvider.Validate())
                {
                    OnSaved(customer);
                }
            };
            //Cancel button click
            ucActionResultButton.CancelButtonClick += (sender, e) =>
            {
                this.Close();
            };
        }
        public Customer customer
        {
            get
            {
                return bsCustomer.DataSource as Customer;
            }
            set
            {
                bsCustomer.DataSource = value as object ?? typeof(Customer);
            }
        }
    }
}
