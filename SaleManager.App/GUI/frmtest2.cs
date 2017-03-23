using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using SaleManager.Data.Models;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
namespace SaleManager.App.GUI
{
    public partial class frmtest2 : frmBase
    {
        private List<ReceiptNoteDetail> list = new List<ReceiptNoteDetail>();
        public frmtest2()
        {
            InitializeComponent();
            //Load
            Load += (sender, e) => 
            {
                LoadStaff();
                LoadStock();
                LoadSupplier();
                LoadRepositoryItemLookUpEdit();
                gridControl1.DataSource = list;
            };
        }
        private void LoadSupplier() 
        {
            cbxSupplier.Properties.DataSource = unitOfWork.SupplierService.GetAllForCombobox().ToList();
            cbxSupplier.Properties.ValueMember = "SupplierId";
            cbxSupplier.Properties.DisplayMember = "Name";
        }
        private void LoadStaff()
        {
            cbxStaff.Properties.DataSource = unitOfWork.StaffService.GetAllForCombobox().ToList();
            cbxStaff.Properties.ValueMember = "StaffId";
            cbxStaff.Properties.DisplayMember = "Fullname";
        }
        private void LoadStock()
        {
            cbxStock.Properties.DataSource = unitOfWork.StockService.GetAllForCombobox().ToList();
            cbxStock.Properties.ValueMember = "StockId";
            cbxStock.Properties.DisplayMember = "Name";
        }
        private void LoadRepositoryItemLookUpEdit() 
        {
            repositoryItemLookUpEdit1.DisplayMember = "Name";
            repositoryItemLookUpEdit1.ValueMember = "ProduceId";
            repositoryItemLookUpEdit1.DataSource = unitOfWork.ProduceService.GetAllForCombobox().ToList();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            list.Add(new ReceiptNoteDetail());
            gridControl1.RefreshDataSource();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var lists = gridControl1.DataSource as List<ReceiptNoteDetail>;
            if (lists.Count() > 0) 
            {
                var note = new ReceiptNote();
                note.SupplierId = (int)cbxSupplier.EditValue;
                note.StockId = (int)cbxStock.EditValue;
                note.StaffId = (int)cbxStaff.EditValue;
                note.Date = (DateTime)txtDate.EditValue;
            }
        }
        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 46) 
            {
                var currentItem = gridView1.GetFocusedRow() as ReceiptNoteDetail;
                list.Remove(currentItem);
                gridControl1.RefreshDataSource();
            }
        }
        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            //GridView view = sender as GridView;
            //GridColumn proCol = view.Columns[0];

            //Int32 proId = (Int32)view.GetRowCellValue(e.RowHandle, proCol);
            //if (proId < 1) {
            //    e.Valid = false;
            //    view.SetColumnError(proCol, "Hãy chọn sản phẩm");
            //}
        }

        private void btnProduceAdd_Click(object sender, EventArgs e)
        {
            frmProduce frm = new frmProduce();
            frm.OnSaved += t => 
            {
                var produce = t as Produce;
                unitOfWork.ProduceService.Create(produce);
                unitOfWork.Save();
                //reload repository lookup edit
                LoadRepositoryItemLookUpEdit();
                frm.Close();
            };
            frm.ShowDialog();
        }

        

    }
}
