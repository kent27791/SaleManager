using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using SaleManager.Service.UnitOfWork;
using SaleManager.Data.Models;
namespace SaleManager.App.GUI
{
    public partial class frmBase : Form
    {
        public delegate void SaveHandler(object obj);

        private UnitOfWork _unitOfWork;
        public UnitOfWork unitOfWork 
        {
            get 
            {
                if (_unitOfWork == null) {
                    _unitOfWork = new UnitOfWork(new SaleManagementContext());
                }
                return _unitOfWork; 
            }
        }
        public frmBase()
        {
            InitializeComponent();
        }
    }
}
