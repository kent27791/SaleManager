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
    public partial class frmCustomers : frmBase
    {
        public frmCustomers()
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
                frmCustomer frm = new frmCustomer();
                frm.OnSaved += t =>
                {
                    var customer = (Customer)t;
                    unitOfWork.CustomerService.Create(customer);
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
                frmCustomer frm = new frmCustomer();
                //send data
                frm.customer = unitOfWork.CustomerService.Find(customerId);
                frm.OnSaved += t =>
                {
                    var customer = (Customer)t;
                    unitOfWork.CustomerService.Update(customer);
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
                var messageBox = MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên này # : " + customerId, "Thông báo", MessageBoxButtons.OKCancel);
                if (messageBox == DialogResult.OK)
                {
                    unitOfWork.CustomerService.Delete(customerId);
                    unitOfWork.Save();
                    //reload gridview
                    BindingGridView();
                }
            };
        }


        private int customerId
        {
            get
            {
                return (gvCustomer.GetFocusedRow() as Customer).CustomerId;
            }
        }
        private void BindingGridView()
        {
            var customers = unitOfWork.CustomerService.GetAll();
            gcCustomer.DataSource = customers.ToList();
        }
    }
}
