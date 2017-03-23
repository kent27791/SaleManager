using System;
using System.Collections.Generic;

namespace SaleManager.Data.Models
{
    public partial class StaffGroup
    {
        public StaffGroup()
        {
            this.Staffs = new List<Staff>();
        }

        public int StaffGroupId { get; set; }
        public string ComputedId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Staff> Staffs { get; set; }
    }
}
