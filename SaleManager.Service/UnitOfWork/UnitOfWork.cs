using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SaleManager.Data.Models;
using SaleManager.Service.Services;
namespace SaleManager.Service.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SaleManagementContext _context;

        private readonly ProduceService _produceService;
        private readonly ProduceGroupService _produceGroupService;

        private readonly StaffService _staffService;
        private readonly StaffGroupService _staffGroupService;

        private readonly CustomerService _customerService;
        private readonly UnitService _unitService;
        private readonly SupplierService _supplierService;
        private readonly StockService _stockService;

        private readonly ReceiptNoteService _receiptNoteService;
        private readonly DeliveryNoteService _deliveryNoteService;
        public UnitOfWork(SaleManagementContext context)
        {
            this._context = context;
            this._produceService = new ProduceService(context);
            this._produceGroupService = new ProduceGroupService(context);

            this._staffService = new StaffService(context);
            this._staffGroupService = new StaffGroupService(context);

            this._customerService = new CustomerService(context);
            this._unitService = new UnitService(context);
            this._supplierService = new SupplierService(context);
            this._stockService = new StockService(context);

            this._receiptNoteService = new ReceiptNoteService(context);
            this._deliveryNoteService = new DeliveryNoteService(context);
            
        }

        public ProduceService ProduceService
        {
            get { return _produceService; }
        }
        public StaffService StaffService
        {
            get { return _staffService;}
        }
        public StaffGroupService StaffGroupService
        {
            get { return _staffGroupService; }
        }
        public CustomerService CustomerService 
        {
            get { return _customerService; }
        }
        public ProduceGroupService ProduceGroupService
        {
            get { return _produceGroupService; }
        }
        public UnitService UnitService
        {
            get { return _unitService; }
        }
        public SupplierService SupplierService
        {
            get { return _supplierService; }
        }
        public StockService StockService
        {
            get { return _stockService; }
        }

        public ReceiptNoteService ReceiptNoteService
        {
            get { return _receiptNoteService; }
        }
        public DeliveryNoteService DeliveryNoteService
        {
            get { return _deliveryNoteService; }
        }
        public void Save()
        {
            _context.SaveChanges();
        }

        #region Disposed
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion

    }
}
