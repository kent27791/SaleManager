using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SaleManager.App.GUI.UserControls
{
    public enum InvoiceState
    {
        Empty = 0,
        InvoiceAdd = 1,
        InvoiceEdit = 2,
        InvoiceDelete = 3,
    }
    public partial class ucActionButton : UserControl
    {
        public ucActionButton()
        {
            InitializeComponent();
            btnAdd.Click += (sender, e) => AddButtonClick(sender, e);
            btnEdit.Click += (sender, e) => EditButtonClick(sender, e);
            btnDelete.Click += (sender, e) => DeleteButtonClick(sender, e);
            txtSearch.TextChanged += (sender, e) => SearchTextChanged(sender, e);
        }
        public InvoiceState InvoiceState { get; set; }
        public event EventHandler AddButtonClick = (s, e) => { };
        public event EventHandler EditButtonClick = (s, e) => { };
        public event EventHandler DeleteButtonClick = (s, e) => { };
        public event EventHandler SearchTextChanged = (s, e) => { };
    }
}
