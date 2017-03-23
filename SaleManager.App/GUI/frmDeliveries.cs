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
    public partial class frmDeliveries : frmBase
    {
        public frmDeliveries()
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
                frmDelivery frm = new frmDelivery();
                frm.OnSaved += t => 
                {
                    var note = t as DeliveryNote;
                    unitOfWork.DeliveryNoteService.Create(note);
                    unitOfWork.Save();
                    //reload gridview
                    BindingGridView();
                    frm.Close();
                };
                frm.ShowDialog();
            };
            ucActionButton.EditButtonClick += (sender, e) =>
            {
                frmDelivery frm = new frmDelivery();
                //send data
                frm.deliveryNote = unitOfWork.DeliveryNoteService.Find(deliveryNoteId);
                frm.OnSaved += t =>
                {
                    var note = t as DeliveryNote;
                    unitOfWork.DeliveryNoteService.Update(note);
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
                var messageBox = MessageBox.Show("Bạn chắc chắn muốn xóa đơn hàng xuất này # : " + deliveryNoteId, "Thông báo", MessageBoxButtons.OKCancel);
                if (messageBox == DialogResult.OK)
                {
                    unitOfWork.DeliveryNoteService.Delete(deliveryNoteId);
                    unitOfWork.Save();
                    //reload gridview
                    BindingGridView();
                }
            };
        }

        private void BindingGridView()
        {
            var deliveryNotes = unitOfWork.DeliveryNoteService.GetViewDelivery();
            gcDeliveryNote.DataSource = deliveryNotes.ToList();
        }
        private int deliveryNoteId
        {
            get
            {
                return (gvDeliveryNote.GetFocusedRow() as vDelivery).DeliveryNoteId;
            }
        }
    }
}
