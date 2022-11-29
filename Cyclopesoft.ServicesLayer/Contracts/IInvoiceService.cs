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
        InvoiceResponse SaveInvoice(InvoiceSaveDto invoiceSaveDto);
        InvoiceResponse UpdateInvoice(InvoiceUpdateDto invoiceSaveDto);
        InvoiceResponse RemoveInvoice(InvoiceRemoveDto invoiceSaveDto);
        ServiceResult GetInvoice();
        ServiceResult GetInvoiceInvoice();
    }
}
