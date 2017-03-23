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
    public partial class ucActionResultButton : UserControl
    {
        public ucActionResultButton()
        {
            InitializeComponent();
            btnSave.Click += (sender, e) => SaveButtonClick(sender, e);
            btnCancel.Click += (sender, e) => CancelButtonClick(sender, e);
        }
        public event EventHandler SaveButtonClick = (s, e) => { };
        public event EventHandler CancelButtonClick = (s, e) => { };
    }
}
