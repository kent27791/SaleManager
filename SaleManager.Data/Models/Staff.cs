using System;
using System.Collections.Generic;

namespace SaleManager.Data.Models
{
    public partial class Staff
    {
        public Staff()
        {
            this.DeliveryNotes = new List<DeliveryNote>();
            this.ReceiptNotes = new List<ReceiptNote>();
        }

        public int StaffId { get; set; }
        public string ComputedId { get; set; }
        public int StaffGroupId { get; set; }
        public string Fullname { get; set; }
        public string IdCard { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public bool IsWorking { get; set; }
        public virtual ICollection<DeliveryNote> DeliveryNotes { get; set; }
        public virtual ICollection<ReceiptNote> ReceiptNotes { get; set; }
        public virtual StaffGroup StaffGroup { get; set; }
    }
}
