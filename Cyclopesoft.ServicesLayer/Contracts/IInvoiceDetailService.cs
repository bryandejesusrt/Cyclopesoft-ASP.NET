using Cyclopesoft.ServicesLayer.Core;
using Cyclopesoft.ServicesLayer.Dtos;
using Cyclopesoft.ServicesLayer.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cyclopesoft.ServicesLayer.Contracts
{
    public interface IInvoiceDetailService : IBaseService
    {
        InvoiceDetailResponse SaveInvoiceDetail(InvoiceDetailSaveDto invoiceDetailSaveDto);
        InvoiceDetailResponse UpdateInvoiceDetail(InvoiceDetailUpdateDto invoiceDetailSaveDto);
        InvoiceDetailResponse RemoveInvoiceDetail(InvoiceDetailRemoveDto invoiceDetailSaveDto);
    }
}
