using Cyclopesoft.ServicesLayer.Core;
using Cyclopesoft.ServicesLayer.Dtos;
using Cyclopesoft.ServicesLayer.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cyclopesoft.ServicesLayer.Contracts
{
    public interface IProductService
    {
        ProductResponse SaveClient(ProductSaveDto productSaveDto);
        ProductResponse UpdateClient(ProductUpdateDto productSaveDto);
        ProductResponse RemoveClient(ProductRemoveDto productSaveDto);
        ServiceResult GetClient();
        ServiceResult GetClientInvoice();
    }
}
