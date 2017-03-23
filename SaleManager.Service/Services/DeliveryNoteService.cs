using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SaleManager.Data.Models;
using SaleManager.Data.ViewModels;
namespace SaleManager.Service.Services
{
    public class DeliveryNoteService : Service<DeliveryNote>
    {
        public DeliveryNoteService(SaleManagementContext context)
            : base(context)
        {
        }
        public IEnumerable<vDelivery> GetViewDelivery()
        {
            //excute view to get data
            //var notes = this._context.Database.SqlQuery<vDelivery>("SELECT * FROM vDelivery");

            //use linq to get data
            var notes = this._dbSet.Select(s => new vDelivery
            {
                Date = s.Date,
                Produces = s.DeliveryNoteDetails.Count,
                DeliveryNoteId = s.DeliveryNoteId,
                Staff = s.Staff.Fullname,
                Stock = s.Stock.Name,
                Customer = s.Customer.Fullname,
                ComputedId = s.ComputedId
            });
            return notes;
        }
    }
}
