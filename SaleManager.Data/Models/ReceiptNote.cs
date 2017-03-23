using System;
using System.Collections.Generic;

namespace SaleManager.Data.Models
{
    public partial class ReceiptNote
    {
        public ReceiptNote()
        {
            this.ReceiptNoteDetails = new List<ReceiptNoteDetail>();
        }

        public int ReceiptNoteId { get; set; }
        public string ComputedId { get; set; }
        public int SupplierId { get; set; }
        public int StockId { get; set; }
        public int StaffId { get; set; }
        public System.DateTime Date { get; set; }
        public virtual Staff Staff { get; set; }
        public virtual Stock Stock { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<ReceiptNoteDetail> ReceiptNoteDetails { get; set; }
    }
}
