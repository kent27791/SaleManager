using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

using SaleManager.Service.UnitOfWork;
using SaleManager.Data.Models;
namespace SaleManager.App.GUI.Reports
{
    public partial class rptProduce : DevExpress.XtraReports.UI.XtraReport
    {
        public rptProduce()
        {
            InitializeComponent();
            BindingSource();
        }
        private void BindingSource()
        {
            xrLabel1.DataBindings.Add("Text", this.DataSource, "ComputedId");
        }
    }
}
