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
    public partial class frmSuppliers : frmBase
    {
        public frmSuppliers()
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
                frmSupplier frm = new frmSupplier();
                frm.OnSaved += t => 
                {
                    var supplier = (Supplier)t;
                    unitOfWork.SupplierService.Create(supplier);
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
                frmSupplier frm = new frmSupplier();
                frm.supplier = unitOfWork.SupplierService.Find(supplierId);
                frm.OnSaved += t =>
                {
                    var supplier = (Supplier)t;
                    unitOfWork.SupplierService.Update(supplier);
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
                var messageBox = MessageBox.Show("Bạn chắc chắn muốn xóa nhà cung cấp này # : " + supplierId, "Thông báo", MessageBoxButtons.OKCancel);
                if (messageBox == DialogResult.OK)
                {
                    unitOfWork.SupplierService.Delete(supplierId);
                    unitOfWork.Save();
                    //reload gridview
                    BindingGridView();
                }
            };
        }

        private int supplierId
        {
            get
            {
                return (gvSupplier.GetFocusedRow() as Supplier).SupplierId;
            }
        }
        private void BindingGridView()
        {
            var suppliers = unitOfWork.SupplierService.GetAll();
            gcSupplier.DataSource = suppliers.ToList();
        }
    }
}
