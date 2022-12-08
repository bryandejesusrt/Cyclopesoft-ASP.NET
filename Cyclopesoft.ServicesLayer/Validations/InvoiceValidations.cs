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

            if (invoice.Serie == null)
            {
                result.Success = false;
                result.Message = "Invoice serial is missing";
                return result;
            }
            if (invoice.RNC == null)
            {
                result.Success = false;
                result.Message = "Invoice RNC is missing";
                return result;
            }
            if (invoice.Expiration_Date == null)
            {
                result.Success = false;
                result.Message = "Invoice Expiration Date is missing";
                return result;
            }
            if (invoice.Payment_Type == null)
            {
                result.Success = false;
                result.Message = "Invoice Payment Type is missing";
                return result;
            }
            if (invoice.Client_Id == null)
            {
                result.Success = false;
                result.Message = "Invoice Note is missing";
                return result;
            }
            if (invoice.User_Id == null)
            {
                result.Success = false;
                result.Message = "Invoice Note is missing";
                return result;
            }
            if (invoice.Subtotal == null)
            {
                result.Success = false;
                result.Message = "Invoice Note is missing";
                return result;
            }
            if (invoice.Taxes == null)
            {
                result.Success = false;
                result.Message = "Invoice Note is missing";
                return result;
            }
            if (invoice.Total == null)
            {
                result.Success = false;
                result.Message = "Invoice Note is missing";
                return result;
            }
            if (invoice.Status == null)
            {
                result.Success = false;
                result.Message = "Invoice Note is missing";
                return result;
            }
            if (invoice.Note == null)
            {
                result.Success = false;
                result.Message = "Invoice Note is missing";
                return result;
            }
return result;
        }
    }
}
