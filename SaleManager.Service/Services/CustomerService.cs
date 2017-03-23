using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SaleManager.Data.Models;
namespace SaleManager.Service.Services
{
    public class CustomerService : Service<Customer>
    {
        public CustomerService(SaleManagementContext context)
            : base(context)
        {
        }
        public IEnumerable<object> GetAllForCombobox()
        {
            var customers = this._dbSet.Select(s => new { s.CustomerId, s.ComputedId, s.Fullname });
            return customers;
        }
    }
}
