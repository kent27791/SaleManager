using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using SaleManager.Data.Models;
namespace SaleManager.App.GUI
{
    public partial class frmtest : frmBase
    {
        //private DataTable dt;
        public frmtest()
        {
            InitializeComponent();
            
            //Load += (sender, e) => 
            //{
            //    dt = new DataTable();
            //    dt.Columns.Add("ProduceId");
            //    dt.Columns.Add("Quantity");
            //    dt.Columns.Add("Price");
            //    gcProduce.DataSource = dt;

            cbxProduce.Properties.DisplayMember = "Name";
            cbxProduce.Properties.ValueMember = "ProduceId";
            cbxProduce.Properties.DataSource = unitOfWork.ProduceService.GetAllForCombobox().ToList();
            //};
            //btnProduceAdd.Click += (sender, e) => 
            //{
            //    DataRow dr = dt.NewRow();
            //    dr["ProduceId"] = cbxProduce.EditValue;
            //    dr["Quantity"] = txtQuantity.Text;
            //    dr["Price"] = txtPrice.Text;
            //    dt.Rows.Add(dr);
            //};
            ucActionResultButton1.SaveButtonClick += (sender, e) => 
            {
                var list = new List<ReceiptNoteDetail>();
                foreach (ListViewItem item in listView1.Items)
                {
                    var r = new ReceiptNoteDetail();
                    r.ProduceId = Convert.ToInt32(item.SubItems[0].Text);
                    r.Quantity = Convert.ToInt32(item.SubItems[1].Text);
                    r.Price = Convert.ToDecimal(item.SubItems[2].Text);
                    list.Add(r);
                }
            };
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            ListViewItem lvItem = new ListViewItem(cbxProduce.EditValue.ToString());
            lvItem.SubItems.Add(txtQuantity.Text);
            lvItem.SubItems.Add(txtPrice.Text);
            listView1.Items.Add(lvItem);
        }
    }
}
