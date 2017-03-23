using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SaleManager.Data.Models;
namespace SaleManager.Service.Services
{
    public class StockService : Service<Stock>
    {
        public StockService(SaleManagementContext context)
            : base(context)
        {
        }
        public IEnumerable<object> GetAllForCombobox()
        {
            var stocks = this._dbSet.Select(s => new { s.StockId, s.ComputedId, s.Name });
            return stocks;
        }
    }
}
