using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SaleManager.App
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
            //Application.Run(new SaleManager.App.GUI.frmtest2());
            //Application.Run(new SaleManager.App.GUI.frmReceipts());
            //Application.Run(new SaleManager.App.GUI.frmDeliveries());
            //Application.Run(new SaleManager.App.GUI.Reports.frmReportProduce());
        }
    }
}
