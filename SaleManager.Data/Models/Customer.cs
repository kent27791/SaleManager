using System;
using System.Collections.Generic;

namespace SaleManager.Data.Models
{
    public partial class Customer
    {
        public Customer()
        {
            this.DeliveryNotes = new List<DeliveryNote>();
        }

        public int CustomerId { get; set; }
        public string ComputedId { get; set; }
        public string Fullname { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public virtual ICollection<DeliveryNote> DeliveryNotes { get; set; }
    }
}
