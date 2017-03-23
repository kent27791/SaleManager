using System;
using System.Collections.Generic;

namespace SaleManager.Data.Models
{
    public partial class Unit
    {
        public Unit()
        {
            this.Produces = new List<Produce>();
        }

        public int UnitId { get; set; }
        public string ComputedId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Produce> Produces { get; set; }
    }
}
