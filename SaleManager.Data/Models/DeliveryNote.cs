using System;
using System.Collections.Generic;

namespace SaleManager.Data.Models
{
    public partial class DeliveryNote
    {
        public DeliveryNote()
        {
            this.DeliveryNoteDetails = new List<DeliveryNoteDetail>();
        }

        public int DeliveryNoteId { get; set; }
        public string ComputedId { get; set; }
        public int CustomerId { get; set; }
        public int StockId { get; set; }
        public int StaffId { get; set; }
        public System.DateTime Date { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Staff Staff { get; set; }
        public virtual Stock Stock { get; set; }
        public virtual ICollection<DeliveryNoteDetail> DeliveryNoteDetails { get; set; }
    }
}
