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
    public partial class frmProduce : frmBase
    {
        public event SaveHandler OnSaved = t => { };

        public frmProduce()
        {
            InitializeComponent();
            //Load
            Load += (sender, e) => 
            {
                if (produce == null)
                    produce = new Produce();
                //load combobox
                LoadUnit();
                LoadProduceGroup();
            };
            //Save button click
            ucActionResultButton.SaveButtonClick += (sender, e) =>
            {
                if (dxValidationProvider.Validate())
                {
                    OnSaved(produce);
                }
            };
            //Cancel button click
            ucActionResultButton.CancelButtonClick += (sender, e) =>
            {
                this.Close();
            };

            //Unit add button click
            btnUnitAdd.Click += (sender, e) => 
            {
                frmUnit frm = new frmUnit();
                frm.OnSaved += t => 
                {
                    unitOfWork.UnitService.Create(t as Unit);
                    unitOfWork.Save();
                    //reload combobox
                    LoadUnit();
                    frm.Close();
                };
                frm.ShowDialog();
            };
            //Produce group add button click
            btnProduceGroupAdd.Click += (sender, e) => 
            {
                frmProduceGroup frm = new frmProduceGroup();
                frm.OnSaved += t => 
                {
                    unitOfWork.ProduceGroupService.Create(t as ProduceGroup);
                    unitOfWork.Save();
                    //reload comboxbox
                    LoadProduceGroup();
                    frm.Close();
                };
                frm.ShowDialog();
            };
        }

        public Produce produce
        {
            get
            {
                return bsProduce.DataSource as Produce;
            }
            set
            {
                bsProduce.DataSource = value as object ?? typeof(Produce);
            }
        }
        private void LoadUnit()
        {
            cbxUnit.Properties.DisplayMember = "Name";
            cbxUnit.Properties.ValueMember = "UnitId";
            cbxUnit.Properties.DataSource = unitOfWork.UnitService.GetAllForCombobox().ToList();
        }
        private void LoadProduceGroup()
        {
            cbxProduceGroup.Properties.DisplayMember = "Name";
            cbxProduceGroup.Properties.ValueMember = "ProduceGroupId";
            cbxProduceGroup.Properties.DataSource = unitOfWork.ProduceGroupService.GetAllForCombobox().ToList();
        }
    }
}
