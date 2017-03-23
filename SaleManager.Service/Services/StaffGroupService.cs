using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SaleManager.Data.Models;
namespace SaleManager.Service.Services
{
    public class StaffGroupService : Service<StaffGroup>
    {
        public StaffGroupService(SaleManagementContext context)
            : base(context)
        {
        }
        public IEnumerable<object> GetAllForCombobox() 
        {
            var staffGroups = this._dbSet.Select(s => new { s.StaffGroupId, s.ComputedId, s.Name });
            return staffGroups;
        }
    }
}
