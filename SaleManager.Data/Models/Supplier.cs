using System;
using System.Collections.Generic;

namespace SaleManager.Data.Models
{
    public partial class Supplier
    {
        public Supplier()
        {
            this.ReceiptNotes = new List<ReceiptNote>();
        }

        public int SupplierId { get; set; }
        public string ComputedId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }
        public virtual ICollection<ReceiptNote> ReceiptNotes { get; set; }
    }
}
