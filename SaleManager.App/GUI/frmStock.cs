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
    public partial class frmStock : frmBase
    {
        public event SaveHandler OnSaved = t => { };

        public frmStock()
        {
            InitializeComponent();
            //Load
            Load += (sender, e) =>
            {
                if (stock == null)
                    stock = new Stock();
            };
            //Save button click
            ucActionResultButton.SaveButtonClick += (sender, e) =>
            {
                if (dxValidationProvider.Validate())
                {
                    OnSaved(stock);
                }
            };
            //Cancel button click
            ucActionResultButton.CancelButtonClick += (sender, e) =>
            {
                this.Close();
            };
        }

        public Stock stock
        {
            get
            {
                return bsStock.DataSource as Stock;
            }
            set
            {
                bsStock.DataSource = value as object ?? typeof(Stock);
            }
        }
    }
}
