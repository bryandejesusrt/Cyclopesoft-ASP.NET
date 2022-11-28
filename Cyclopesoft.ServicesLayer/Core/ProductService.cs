using Cyclopesoft.DataLayer.Interface;
using Cyclopesoft.ServicesLayer.Contracts;
using Cyclopesoft.ServicesLayer.Dtos;
using Cyclopesoft.ServicesLayer.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cyclopesoft.ServicesLayer.Core
{
    public class ProductService : IProductService
    {
        public ServiceResult GetClient()
        {
            throw new NotImplementedException();
        }

        public ServiceResult GetClientInvoice()
        {
            throw new NotImplementedException();
        }

        public ProductResponse RemoveClient(ProductRemoveDto productSaveDto)
        {
            throw new NotImplementedException();
        }

        public ProductResponse SaveClient(ProductSaveDto productSaveDto)
        {
            throw new NotImplementedException();
        }

        public ProductResponse UpdateClient(ProductUpdateDto productSaveDto)
        {
            throw new NotImplementedException();
        }
    }
}
