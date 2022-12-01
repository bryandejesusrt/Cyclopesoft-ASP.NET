using Cyclopesoft.ServicesLayer.Core;
using Cyclopesoft.ServicesLayer.Dtos;
using Cyclopesoft.ServicesLayer.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cyclopesoft.ServicesLayer.Contracts
{
    public interface IProductService : IBaseService
    {

        ProductResponse SaveProduct(ProductSaveDto productSaveDto);
        ProductResponse UpdateProduct(ProductUpdateDto productSaveDto);
        ProductResponse RemoveProduct(ProductRemoveDto productSaveDto);
        
    }
}
