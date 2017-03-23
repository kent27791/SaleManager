using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using SaleManager.Data.ViewModels;
using SaleManager.Data.Models;
namespace SaleManager.App.GUI
{
    public partial class frmProduces : frmBase
    {
        public frmProduces()
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
                frmProduce frm = new frmProduce();
                frm.OnSaved += t => 
                {
                    var produce = t as Produce;
                    unitOfWork.ProduceService.Create(produce);
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
                frmProduce frm = new frmProduce();
                //send data
                frm.produce = unitOfWork.ProduceService.Find(produceId);
                frm.OnSaved += t =>
                {
                    var produce = t as Produce;
                    unitOfWork.ProduceService.Update(produce);
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
                var messageBox = MessageBox.Show("Bạn chắc chắn muốn xóa sản phẩm này # : " + produceId, "Thông báo", MessageBoxButtons.OKCancel);
                if (messageBox == DialogResult.OK)
                {
                    unitOfWork.ProduceService.Delete(produceId);
                    unitOfWork.Save();
                    //reload gridview
                    BindingGridView();
                }
            };
        }
        private int produceId
        {
            get
            {
                return (gvProduce.GetFocusedRow() as vProduce).ProduceId;
            }
        }
        private void BindingGridView()
        {
            var produces = unitOfWork.ProduceService.GetViewProduce();
            gcProduce.DataSource = produces.ToList();
        }
    }
}
