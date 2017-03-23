using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SaleManager.Data.Models;
namespace SaleManager.Service.Services
{
    public class UnitService : Service<Unit>
    {
        public UnitService(SaleManagementContext context)
            : base(context)
        {
        }
        public IEnumerable<object> GetAllForCombobox() 
        {
            var units = this._dbSet.Select(s => new { s.UnitId, s.ComputedId, s.Name });
            return units;
        }
    }
}
