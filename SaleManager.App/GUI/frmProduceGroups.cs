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
    public partial class frmProduceGroups : frmBase
    {
        public frmProduceGroups()
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
                frmProduceGroup frm = new frmProduceGroup();
                frm.OnSaved += t =>
                {
                    var produceGroup = (ProduceGroup)t;
                    unitOfWork.ProduceGroupService.Create(produceGroup);
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
                frmProduceGroup frm = new frmProduceGroup();
                //send data
                frm.produceGroup = unitOfWork.ProduceGroupService.Find(produceGroupId);
                frm.OnSaved += t =>
                {
                    var produceGroup = (ProduceGroup)t;
                    unitOfWork.ProduceGroupService.Update(produceGroup);
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
                var messageBox = MessageBox.Show("Bạn chắc chắn muốn xóa nhóm sản phẩm này # : " + produceGroupId, "Thông báo", MessageBoxButtons.OKCancel);
                if (messageBox == DialogResult.OK)
                {
                    unitOfWork.ProduceGroupService.Delete(produceGroupId);
                    unitOfWork.Save();
                    //reload gridview
                    BindingGridView();
                }
            };
        }

        private int produceGroupId
        {
            get
            {
                return (gvProduceGroup.GetFocusedRow() as ProduceGroup).ProduceGroupId;
            }
        }
        private void BindingGridView()
        {
            var produceGroups = unitOfWork.ProduceGroupService.GetAll();
            gcProduceGroup.DataSource = produceGroups.ToList();
        }
    }
}
