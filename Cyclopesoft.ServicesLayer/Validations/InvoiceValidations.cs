using Cyclopesoft.DataLayer.Entities;
using Cyclopesoft.ServicesLayer.Core;
using Cyclopesoft.ServicesLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cyclopesoft.ServicesLayer.Validations
{
    public class InvoiceValidations
    {
        public static ServiceResult AssertInvoiceIsValid(InvoiceSaveDto invoice)
        {
            ServiceResult result = new ServiceResult();
            if (invoice.Name == null)
            {
                result.Success = false;
                result.Message = "Invoice serial is missing";
                return result;
            }
            if (invoice.LastName == null)
            {
                result.Success = false;
                result.Message = "Invoice RNC is missing";
                return result;
            }
            if (invoice.Email == null)
            {
                result.Success = false;
                result.Message = "Invoice Expiration Date is missing";
                return result;
            }
            if (invoice.Phone == null)
            {
                result.Success = false;
                result.Message = "Invoice Payment Type is missing";
                return result;
            }
            if (invoice.BusinessName == null)
            {
                result.Success = false;
                result.Message = "Invoice Note is missing";
                return result;
            }
            if (invoice.DirectIn == null)
            {
                result.Success = false;
                result.Message = "Invoice Note is missing";
                return result;
            }
            if (invoice.CreationDate == null)
            {
                result.Success = false;
                result.Message = "Invoice Note is missing";
                return result;
            }
            return result;
        }
    }
}
