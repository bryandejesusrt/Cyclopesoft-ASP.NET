using Cyclopesoft.ServicesLayer.Core;
using Cyclopesoft.ServicesLayer.Dtos;
using Cyclopesoft.ServicesLayer.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cyclopesoft.ServicesLayer.Contracts
{
    public interface IInvoiceService : IBaseService
    {
        public InvoiceSaveResponse SaveInvoice(InvoiceSaveDto invoiceSaveDto);
        public InvoiceUpdateResponse UpdateInvoice(InvoiceUpdateDto invoiceSaveDto);
        public InvoiceRemoveResponse RemoveInvoice(InvoiceRemoveDto invoiceSaveDto);
    }
}
