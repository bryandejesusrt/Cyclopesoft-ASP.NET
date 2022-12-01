using Cyclopesoft.ServicesLayer.Core;
using Cyclopesoft.ServicesLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cyclopesoft.ServicesLayer.Validations
{
    public class InvoiceDetailValidations
    {
        public static ServiceResult AssertInvoiceDetailIsValid(InvoiceDetailSaveDto invoiceDetails)
        {
            ServiceResult result = new ServiceResult();
            if (invoiceDetails.Name == null)
            {
                result.Success = false;
                result.Message = "Invoice serial is missing";
                return result;
            }
            if (invoiceDetails.LastName == null)
            {
                result.Success = false;
                result.Message = "Invoice RNC is missing";
                return result;
            }
            if (invoiceDetails.Email == null)
            {
                result.Success = false;
                result.Message = "Invoice Expiration Date is missing";
                return result;
            }
            if (invoiceDetails.Phone == null)
            {
                result.Success = false;
                result.Message = "Invoice Payment Type is missing";
                return result;
            }
            if (invoiceDetails.BusinessName == null)
            {
                result.Success = false;
                result.Message = "Invoice Note is missing";
                return result;
            }
            if (invoiceDetails.DirectIn == null)
            {
                result.Success = false;
                result.Message = "Invoice Note is missing";
                return result;
            }
            if (invoiceDetails.CreationUser == null)
            {
                result.Success = false;
                result.Message = "Invoice Note is missing";
                return result;
            }
            return result;
        }
    }
}
