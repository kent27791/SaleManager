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
    public partial class frmUnit : frmBase
    {
        public event SaveHandler OnSaved = t => { };

        public frmUnit()
        {
            InitializeComponent();
            //Load
            Load += (sender, e) => 
            {
                if (unit == null)
                    unit = new Unit();
            };
            //Save button click
            ucActionResultButton.SaveButtonClick += (sender, e) => 
            {
                if (dxValidationProvider.Validate())
                {
                    OnSaved(unit);
                }
            };
            //Cancel button click
            ucActionResultButton.CancelButtonClick += (sender, e) => 
            {
                this.Close();
            };
        }
        public Unit unit 
        {
            get 
            {
                return bsUnit.DataSource as Unit;
            }
            set 
            {
                bsUnit.DataSource = value as object ?? typeof(Unit);
            }
        }
    }
}
