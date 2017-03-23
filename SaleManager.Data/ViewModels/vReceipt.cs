using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaleManager.Data.ViewModels
{
    public class vReceipt
    {
        public int ReceiptNoteId { get; set; }
        public string ComputedId { get; set; }
        public DateTime Date { get; set; }
        public string Staff { get; set; }
        public string Supplier { get; set; }
        public string Stock { get; set; }
        public int Produces { get; set; }
    }
}
