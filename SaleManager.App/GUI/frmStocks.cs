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
    public partial class frmStocks : frmBase
    {
        public frmStocks()
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
                frmStock frm = new frmStock();
                frm.OnSaved += t => 
                {
                    var stock = t as Stock;
                    unitOfWork.StockService.Create(stock);
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
                frmStock frm = new frmStock();
                //send data
                frm.stock = unitOfWork.StockService.Find(stockId);
                frm.OnSaved += t =>
                {
                    var stock = t as Stock;
                    unitOfWork.StockService.Update(stock);
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
                var messageBox = MessageBox.Show("Bạn chắc chắn muốn xóa kho hàng này # : " + stockId, "Thông báo", MessageBoxButtons.OKCancel);
                if (messageBox == DialogResult.OK)
                {
                    unitOfWork.StockService.Delete(stockId);
                    unitOfWork.Save();
                    //reload gridview
                    BindingGridView();
                }
            };
        }

        private int stockId
        {
            get
            {
                return (gvStock.GetFocusedRow() as Stock).StockId;
            }
        }
        private void BindingGridView()
        {
            var stocks = unitOfWork.StockService.GetAll();
            gcStock.DataSource = stocks.ToList();
        }
    }
}
