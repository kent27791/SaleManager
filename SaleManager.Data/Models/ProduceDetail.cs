using System;
using System.Collections.Generic;

namespace SaleManager.Data.Models
{
    public partial class ProduceDetail
    {
        public int ProduceId { get; set; }
        public System.DateTime Date { get; set; }
        public int OpeningStock { get; set; }
        public int ClosingStock { get; set; }
        public int InputStock { get; set; }
        public int OutputStock { get; set; }
        public virtual Produce Produce { get; set; }
    }
}
