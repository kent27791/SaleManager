using System;
using System.Collections.Generic;

namespace SaleManager.Data.Models
{
    public partial class ReceiptNoteDetail
    {
        public int ReceiptNoteId { get; set; }
        public int ProduceId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Produce Produce { get; set; }
        public virtual ReceiptNote ReceiptNote { get; set; }
    }
}
