﻿using Cyclopesoft.DataLayer.Interface;
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
        public ServiceResult GetProduct()
        {
            throw new NotImplementedException();
        }

        public ServiceResult GetProductInvoice()
        {
            throw new NotImplementedException();
        }

        public ProductResponse RemoveProduct(ProductRemoveDto productSaveDto)
        {
            throw new NotImplementedException();
        }

        public ProductResponse SaveProduct(ProductSaveDto productSaveDto)
        {
            throw new NotImplementedException();
        }

        public ProductResponse UpdateProduct(ProductUpdateDto productSaveDto)
        {
            throw new NotImplementedException();
        }
    }
}