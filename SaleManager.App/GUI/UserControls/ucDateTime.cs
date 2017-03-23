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
    public partial class ucDateTime : UserControl
    {
        public ucDateTime()
        {
            InitializeComponent();
            //Load
            Load += (sender, e) => 
            {
                
            };
        }
        public event EventHandler TimeChanged = (s, e) => { };
        public DateTime DateTimeFrom 
        {
            get { return txtFrom.DateTime; }
            set { txtFrom.DateTime = value; }
        }
        public DateTime DateTimeTo
        {
            get { return txtTo.DateTime; }
            set { txtTo.DateTime = value; }
        }
    }
}
