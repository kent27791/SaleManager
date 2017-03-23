using System;
using System.Collections.Generic;

namespace SaleManager.Data.Models
{
    public partial class DeliveryNoteDetail
    {
        public int DeliveryNoteId { get; set; }
        public int ProduceId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual DeliveryNote DeliveryNote { get; set; }
        public virtual Produce Produce { get; set; }
    }
}
