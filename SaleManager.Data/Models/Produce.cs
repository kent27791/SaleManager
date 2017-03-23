using System;
using System.Collections.Generic;

namespace SaleManager.Data.Models
{
    public partial class Produce
    {
        public Produce()
        {
            this.DeliveryNoteDetails = new List<DeliveryNoteDetail>();
            this.ProduceDetails = new List<ProduceDetail>();
            this.ReceiptNoteDetails = new List<ReceiptNoteDetail>();
        }

        public int ProduceId { get; set; }
        public string ComputedId { get; set; }
        public string Name { get; set; }
        public int UnitId { get; set; }
        public int ProduceGroupId { get; set; }
        public virtual ICollection<DeliveryNoteDetail> DeliveryNoteDetails { get; set; }
        public virtual ProduceGroup ProduceGroup { get; set; }
        public virtual Unit Unit { get; set; }
        public virtual ICollection<ProduceDetail> ProduceDetails { get; set; }
        public virtual ICollection<ReceiptNoteDetail> ReceiptNoteDetails { get; set; }
    }
}
