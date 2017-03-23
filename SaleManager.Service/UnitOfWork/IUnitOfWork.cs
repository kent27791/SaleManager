using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SaleManager.Service.Services;
namespace SaleManager.Service.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        ProduceService ProduceService { get; }
        ProduceGroupService ProduceGroupService { get; }

        StaffService StaffService { get; }
        StaffGroupService StaffGroupService { get; }

        CustomerService CustomerService { get; }
        UnitService UnitService { get; }
        SupplierService SupplierService { get; }
        StockService StockService { get; }

        ReceiptNoteService ReceiptNoteService { get; }
        DeliveryNoteService DeliveryNoteService { get; }

        void Save();
    }
}
