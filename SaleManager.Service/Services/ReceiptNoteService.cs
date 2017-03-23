using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SaleManager.Data.Models;
using SaleManager.Data.ViewModels;
namespace SaleManager.Service.Services
{
    public class ReceiptNoteService : Service<ReceiptNote>
    {
        public ReceiptNoteService(SaleManagementContext context)
            : base(context)
        {
        }
        public IEnumerable<vReceipt> GetViewReceipt() 
        {
            //excute view to get data
            //var notes = this._context.Database.SqlQuery<vReceipt>("SELECT * FROM vReceipt");

            //use linq to get data
            var notes = this._dbSet.Select(s => new vReceipt
                            {
                                Date = s.Date,
                                Produces = s.ReceiptNoteDetails.Count(),
                                ReceiptNoteId = s.ReceiptNoteId,
                                Staff = s.Staff.Fullname,
                                Stock = s.Stock.Name,
                                Supplier = s.Supplier.Name,
                                ComputedId = s.ComputedId
                            });
            return notes;
        }
    }
}
