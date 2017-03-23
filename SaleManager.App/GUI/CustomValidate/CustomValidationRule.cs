using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DevExpress.XtraEditors.DXErrorProvider;
using SaleManager.Service.UnitOfWork;
using SaleManager.Data.Models;
namespace SaleManager.App.GUI.CustomValidate
{
    public class CustomValidationRule : ValidationRule 
    {
        //public override bool Validate(System.Windows.Forms.Control control, object value)
        //{
        //    bool flag = false;
        //    String Id = value as String;
        //    if (Id == null)
        //        return flag;
        //    using (UnitOfWork unitOfWork = new UnitOfWork(new SaleManagerContext())) 
        //    {
        //        flag = unitOfWork.ProduceService.IsExist(Id);
        //    }
        //    return flag;
        //}
    }
}
