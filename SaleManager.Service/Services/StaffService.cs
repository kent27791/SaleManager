using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SaleManager.Data.Models;
namespace SaleManager.Service.Services
{
    public class StaffService : Service<Staff>
    {
        public StaffService(SaleManagementContext context)
            : base(context)
        {
        }
        public IEnumerable<object> GetAllForCombobox()
        {
            var staffs = this._dbSet.Select(s => new { s.StaffId, s.ComputedId, s.Fullname });
            return staffs;
        }
    }
}
