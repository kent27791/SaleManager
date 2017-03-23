using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using SaleManager.Data.Models;
using DevExpress.XtraEditors;
namespace SaleManager.App.GUI
{
    public partial class frmUnits : frmBase
    {
        public frmUnits()
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
                frmUnit frm = new frmUnit();
                frm.OnSaved += t => 
                {
                    var unit = (Unit)t;
                    unitOfWork.UnitService.Create(unit);
                    unitOfWork.Save();
                    //reload gridview
                    BindingGridView();
                    frm.Close();
                };
                frm.ShowDialog();
            };
            //Edit button click
            ucActionButton.EditButtonClick += (sender, e) => 
            {
                frmUnit frm = new frmUnit();
                frm.unit = unitOfWork.UnitService.Find(unitId);
                frm.OnSaved += t => 
                {
                    var unit = (Unit)t;
                    unitOfWork.UnitService.Update(unit);
                    unitOfWork.Save();
                    //reload gridview
                    BindingGridView();
                    frm.Close();
                };
                frm.ShowDialog();
            };
            //Delete button click
            ucActionButton.DeleteButtonClick += (sender, e) => 
            {
                var messageBox = MessageBox.Show("Bạn chắc chắn muốn xóa đơn vị tính này này # : " + unitId, "Thông báo", MessageBoxButtons.OKCancel);
                if (messageBox == DialogResult.OK) 
                {
                    unitOfWork.UnitService.Delete(unitId);
                    unitOfWork.Save();
                    //reload gridview
                    BindingGridView();
                }
            };
            //Search 
            ucActionButton.SearchTextChanged += (sender, e) => 
            {
                var term = ((TextEdit)sender).Text;
                gvUnit.ApplyFindFilter(term);
            };
        }
        private int unitId 
        {
            get 
            { 
                return (gvUnit.GetFocusedRow() as Unit).UnitId; 
            }
        }
        private void BindingGridView() 
        {
            var units = unitOfWork.UnitService.GetAll();
            gcUnit.DataSource = units.ToList();
        }
    }
}
