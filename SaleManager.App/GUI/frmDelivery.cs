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
    public partial class frmDelivery : frmBase
    {
        public event SaveHandler OnSaved = t => { };

        public frmDelivery()
        {
            InitializeComponent();
            //Load
            Load += (sender, e) => 
            {
                if (deliveryNote == null)
                    deliveryNote = new DeliveryNote { Date = DateTime.Now };
                //bind combobox
                LoadStaff();
                LoadStock();
                LoadCustomer();
                //bind repository lookup edit
                LoadRepositoryLookupEdit();
                //bind static list variable
                listDeliveryNoteDetails = deliveryNote.DeliveryNoteDetails.ToList();
                //bind gridview
                gcDeliveryNoteDetails.DataSource = listDeliveryNoteDetails;
            };

            //add item to gridview
            gvDeliveryNoteDetails.DoubleClick += (sender, e) =>
            {
                //add new item to static list variable
                listDeliveryNoteDetails.Add(new DeliveryNoteDetail());
                //refresh data source gridview after add new item
                gcDeliveryNoteDetails.RefreshDataSource();
            };
            //remove item to gridview
            gvDeliveryNoteDetails.KeyDown += (sender, e) => 
            {
                if (e.KeyValue == 46) //keyboard delete
                {
                    var currentItem = gvDeliveryNoteDetails.GetFocusedRow() as DeliveryNoteDetail;
                    listDeliveryNoteDetails.Remove(currentItem);
                    //refresh datasouce gridview
                    gcDeliveryNoteDetails.RefreshDataSource();
                }
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
            //Customer add button click
            btnCustomerAdd.Click += (sender, e) => 
            {
                frmCustomer frm = new frmCustomer();
                frm.OnSaved += t => 
                {
                    unitOfWork.CustomerService.Create(t as Customer);
                    unitOfWork.Save();
                    //reload combobox
                    LoadCustomer();
                    frm.Close();
                };
                frm.ShowDialog();
            };
            //Save button click
            ucActionResultButton.SaveButtonClick += (sender, e) => 
            {
                if (dxValidationProvider.Validate()) 
                {
                    var listItem = gcDeliveryNoteDetails.DataSource as List<DeliveryNoteDetail>;
                    if (listItem.Count > 0) 
                    {
                        deliveryNote.DeliveryNoteDetails = listItem;
                        OnSaved(deliveryNote);
                    }
                }
            };
            //Cancel button click
            ucActionResultButton.CancelButtonClick += (sender, e) => 
            {
                this.Close();
            };
        }

        //load combobox
        private void LoadStaff()
        {
            cbxStaff.Properties.DisplayMember = "Fullname";
            cbxStaff.Properties.ValueMember = "StaffId";
            cbxStaff.Properties.DataSource = unitOfWork.StaffService.GetAllForCombobox().ToList();
        }
        private void LoadCustomer() 
        {
            cbxCustomer.Properties.DisplayMember = "Fullname";
            cbxCustomer.Properties.ValueMember = "CustomerId";
            cbxCustomer.Properties.DataSource = unitOfWork.CustomerService.GetAllForCombobox().ToList();
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

        //static list datasource gridview
        private List<DeliveryNoteDetail> listDeliveryNoteDetails = null;
        public DeliveryNote deliveryNote
        {
            get
            {
                return bsDeliveryNote.DataSource as DeliveryNote;
            }
            set
            {
                bsDeliveryNote.DataSource = value as object ?? typeof(DeliveryNote);
            }
        }
    }
}
