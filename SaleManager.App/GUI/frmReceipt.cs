using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DevExpress.XtraEditors.Repository;
using SaleManager.Data.Models;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
namespace SaleManager.App.GUI
{
    public partial class frmReceipt : frmBase
    {
        public event SaveHandler OnSaved = t => { };
        public frmReceipt()
        {
            InitializeComponent();
            //Load
            Load += (sender, e) => 
            {
                if (receiptNote == null)
                    receiptNote = new ReceiptNote { Date = DateTime.Now };
                //bind combobox
                LoadStaff();
                LoadSupplier();
                LoadStock();
                //bind gridview
                LoadRepositoryLookupEdit();
                listReceiptNoteDetails = receiptNote.ReceiptNoteDetails.ToList();
                //bind gridview to static list
                gcReceiptNoteDetails.DataSource = listReceiptNoteDetails;
                
            };
            //Add item gridview
            gvReceiptNoteDetails.DoubleClick += (sender, e) => 
            {
                listReceiptNoteDetails.Add(new ReceiptNoteDetail());
                gcReceiptNoteDetails.RefreshDataSource();
            };
            //Remove item gridview
            gvReceiptNoteDetails.KeyDown += (sender, e) => 
            {
                if (e.KeyValue == 46) //keyboard delete
                {
                    var currentItem = gvReceiptNoteDetails.GetFocusedRow() as ReceiptNoteDetail;
                    //delete from list
                    listReceiptNoteDetails.Remove(currentItem);
                    //rebinding gridview
                    gcReceiptNoteDetails.RefreshDataSource();
                }
            };
            //Produce add button click
            btnProduceAdd.Click += (sender, e) => 
            {
                frmProduce frm = new frmProduce();
                frm.OnSaved += t => 
                {
                    var produce = t as Produce;
                    unitOfWork.ProduceService.Create(produce);
                    unitOfWork.Save();
                    //reload repository produce
                    LoadRepositoryLookupEdit();
                    frm.Close();
                };
                frm.ShowDialog();
            };
            //Staff add button click
            btnStaffAdd.Click += (sender, e) => 
            {
                frmStaff frm = new frmStaff();
                frm.OnSaved += t => 
                {
                    unitOfWork.StaffService.Create(t as Staff);
                    unitOfWork.Save();
                    //reload combobox
                    LoadStaff();
                    frm.Close();
                };
                frm.ShowDialog();
            };
            //Supplier add button click
            btnSupplierAdd.Click += (sender, e) => 
            {
                frmSupplier frm = new frmSupplier();
                frm.OnSaved += t => 
                {
                    unitOfWork.SupplierService.Create(t as Supplier);
                    unitOfWork.Save();
                    //reload combobox
                    LoadSupplier();
                    frm.Close();
                };
                frm.ShowDialog();
            };
            //Stock add button click
            btnStockAdd.Click += (sender, e) => 
            {
                frmStock frm = new frmStock();
                frm.OnSaved += t => 
                {
                    unitOfWork.StockService.Create(t as Stock);
                    unitOfWork.Save();
                    //reload combobox
                    LoadStock();
                    frm.Close();
                };
                frm.ShowDialog();
            };
            //Save button click
            ucActionResultButton.SaveButtonClick += (sender, e) => 
            {
                if (dxValidationProvider.Validate()) 
                {
                    var listItem = gvReceiptNoteDetails.DataSource as List<ReceiptNoteDetail>;
                    if (listItem.Count > 0) 
                    {
                        receiptNote.ReceiptNoteDetails = listItem;
                        OnSaved(receiptNote);
                    }
                }
            };
            //Cancel button click
            ucActionResultButton.CancelButtonClick += (sender, e) => 
            {
                this.Close();
            };

            //validate row item
            gvReceiptNoteDetails.ValidateRow += (sender, e) => 
            {
                GridView view = sender as GridView;
                //GridColumn colProduceId = view.Columns[0];
                GridColumn colQuantity = view.Columns[1];
                GridColumn colPrice = view.Columns[2];

                //validate for quanity > 1
                var quanity = (int)view.GetRowCellValue(e.RowHandle, colQuantity);
                if (quanity < 1)
                {
                    e.Valid = false;
                    view.SetColumnError(colQuantity, "Số lượng nhập phải lớn hơn 0");
                    return;
                }
                var price = (decimal)view.GetRowCellValue(e.RowHandle, colPrice);
                if (price < 1000) 
                {
                    e.Valid = false;
                    view.SetColumnError(colPrice, "Giá sản phẩm phải lớn hơn 1000đ");
                    return;
                }
            };
        }
        //static list datasource gridview
        private List<ReceiptNoteDetail> listReceiptNoteDetails = null;
        //Init combobox
        private void LoadStaff() 
        {
            cbxStaff.Properties.DisplayMember = "Fullname";
            cbxStaff.Properties.ValueMember = "StaffId";
            cbxStaff.Properties.DataSource = unitOfWork.StaffService.GetAllForCombobox().ToList();
        }
        private void LoadSupplier()
        {
            cbxSupplier.Properties.DisplayMember = "Name";
            cbxSupplier.Properties.ValueMember = "SupplierId";
            cbxSupplier.Properties.DataSource = unitOfWork.SupplierService.GetAllForCombobox().ToList();
        }
        private void LoadStock()
        {
            cbxStock.Properties.DisplayMember = "Name";
            cbxStock.Properties.ValueMember = "StockId";
            cbxStock.Properties.DataSource = unitOfWork.StockService.GetAllForCombobox().ToList();
        }
        private void LoadRepositoryLookupEdit() 
        {
            repositoryItemLookUpEditProduce.DataSource = unitOfWork.ProduceService.GetAllForCombobox().ToList();
            repositoryItemLookUpEditProduce.DisplayMember = "Name";
            repositoryItemLookUpEditProduce.ValueMember = "ProduceId";
        }
        public ReceiptNote receiptNote 
        {
            get 
            {
                return bsReceiptNote.DataSource as ReceiptNote;
            }
            set 
            {
                bsReceiptNote.DataSource = value as object ?? typeof(ReceiptNote);
            }
        }
    }
}
