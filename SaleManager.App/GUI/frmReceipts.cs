using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using SaleManager.Data.Models;
using SaleManager.Data.ViewModels;
namespace SaleManager.App.GUI
{
    public partial class frmReceipts : frmBase
    {
        public frmReceipts()
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
                frmReceipt frm = new frmReceipt();
                frm.OnSaved += t => 
                {
                    var note = t as ReceiptNote;
                    unitOfWork.ReceiptNoteService.Create(note);
                    unitOfWork.Save();
                    //reload
                    BindingGridView();
                    frm.Close();
                };
                frm.ShowDialog();
            };
            //Edit button click
            ucActionButton.EditButtonClick += (sender, e) => 
            {
                frmReceipt frm = new frmReceipt();
                frm.receiptNote = unitOfWork.ReceiptNoteService.Find(receiptNoteId);
                frm.OnSaved += t =>
                {
                    var note = t as ReceiptNote;
                    unitOfWork.ReceiptNoteService.Update(note);
                    unitOfWork.Save();
                    //reload
                    BindingGridView();
                    frm.Close();
                };
                frm.ShowDialog();
            };
            //Delete button click
            ucActionButton.DeleteButtonClick += (sender, e) =>
            {
                var messageBox = MessageBox.Show("Bạn chắc chắn muốn xóa đơn hàng nhập này # : " + receiptNoteId, "Thông báo", MessageBoxButtons.OKCancel);
                if (messageBox == DialogResult.OK)
                {
                    unitOfWork.ReceiptNoteService.Delete(receiptNoteId);
                    unitOfWork.Save();
                    //reload gridview
                    BindingGridView();
                }
            };
        }

        private void BindingGridView()
        {
            var receiptNotes = unitOfWork.ReceiptNoteService.GetViewReceipt();
            gcReceiptNote.DataSource = receiptNotes.ToList();
        }
        private int receiptNoteId
        {
            get 
            {
                return (gvReceiptNote.GetFocusedRow() as vReceipt).ReceiptNoteId;
            }
        }
    }
}
