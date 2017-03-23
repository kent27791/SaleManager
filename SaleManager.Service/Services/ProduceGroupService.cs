using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SaleManager.Data.Models;
namespace SaleManager.Service.Services
{
    public class ProduceGroupService : Service<ProduceGroup>
    {
        public ProduceGroupService(SaleManagementContext context)
            : base(context)
        {
        }
        public IEnumerable<object> GetAllForCombobox() 
        {
            var produceGroups = this._dbSet.Select(s => new { s.ProduceGroupId, s.ComputedId, s.Name });
            return produceGroups;
        }
    }
}
