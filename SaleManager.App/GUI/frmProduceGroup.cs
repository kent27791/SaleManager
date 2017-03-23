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
    public partial class frmProduceGroup : frmBase
    {
        public event SaveHandler OnSaved = t => { };

        public frmProduceGroup()
        {
            InitializeComponent();
            //Load
            Load += (sender, e) =>
            {
                if (produceGroup == null)
                    produceGroup = new ProduceGroup();
            };
            //Save button click
            ucActionResultButton.SaveButtonClick += (sender, e) =>
            {
                if (dxValidationProvider.Validate())
                {
                    OnSaved(produceGroup);
                }
            };
            //Cancel button click
            ucActionResultButton.CancelButtonClick += (sender, e) =>
            {
                this.Close();
            };
        }

        public ProduceGroup produceGroup
        {
            get
            {
                return bsProduceGroup.DataSource as ProduceGroup;
            }
            set
            {
                bsProduceGroup.DataSource = value as object ?? typeof(ProduceGroup);
            }
        }
    }
}
