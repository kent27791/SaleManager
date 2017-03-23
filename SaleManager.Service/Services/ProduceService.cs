using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SaleManager.Data.Models;
using SaleManager.Data.ViewModels;
namespace SaleManager.Service.Services
{
    public class ProduceService : Service<Produce>
    {
        public ProduceService(SaleManagementContext context)
            : base(context)
        {
        }
        public IEnumerable<vProduce> GetViewProduce() 
        {
            var produces = this._context.Database.SqlQuery<vProduce>("SELECT * FROM vProduce");
            return produces;
        }

        public IEnumerable<object> GetAllForCombobox() 
        {
            //var produces = this._dbSet.Select(s => new { s.ProduceId, s.Name });
            var produces = this._context.Database.SqlQuery<vInventory>("SELECT * FROM vInventory");
            return produces.ToList();
        }
    }
}
