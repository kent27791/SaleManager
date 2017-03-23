using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//using DevExpress.XtraReports.UI;
namespace SaleManager.App.GUI.Reports
{
    public partial class frmReportProduce : frmBase
    {
        public frmReportProduce()
        {
            InitializeComponent();
            //Load
            Load += (sender, e) => 
            {
                var produces = unitOfWork.ProduceService.GetAll().ToList();
                rptProduce rpt = new rptProduce();
                rpt.DataSource = produces;
                //rpt.ShowPreviewDialog();
                ucReport.Report = rpt;
            };
        }
    }
}
