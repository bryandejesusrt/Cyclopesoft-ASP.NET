using Cyclopesoft.ServicesLayer.Core;
using Cyclopesoft.ServicesLayer.Dtos;
using Cyclopesoft.ServicesLayer.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cyclopesoft.ServicesLayer.Contracts
{
    public interface IInvoiceService
    {
        InvoiceResponse SaveInvoice(InvoiceSave invoiceSaveDto);
        InvoiceResponse UpdateInvoice(InvoiceUpdate invoiceSaveDto);
        InvoiceResponse RemoveInvoice(InvoiceRemove invoiceSaveDto);
        ServiceResult GetClient();
        ServiceResult GetInvoiceInvoice();
    }
}
