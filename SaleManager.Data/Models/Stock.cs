using System;
using System.Collections.Generic;

namespace SaleManager.Data.Models
{
    public partial class Stock
    {
        public Stock()
        {
            this.DeliveryNotes = new List<DeliveryNote>();
            this.ReceiptNotes = new List<ReceiptNote>();
        }

        public int StockId { get; set; }
        public string ComputedId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<DeliveryNote> DeliveryNotes { get; set; }
        public virtual ICollection<ReceiptNote> ReceiptNotes { get; set; }
    }
}
