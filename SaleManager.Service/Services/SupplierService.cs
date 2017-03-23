using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SaleManager.Data.Models;
namespace SaleManager.Service.Services
{
    public class SupplierService : Service<Supplier>
    {
        public SupplierService(SaleManagementContext context)
            : base(context)
        {
        }
        public IEnumerable<object> GetAllForCombobox() 
        {
            var suppliers = this._dbSet.Select(s => new { s.SupplierId, s.ComputedId, s.Name });
            return suppliers;
        }
    }
}
