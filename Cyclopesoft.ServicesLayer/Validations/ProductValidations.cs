using Cyclopesoft.DataLayer.Entities;
using Cyclopesoft.ServicesLayer.Core;
using Cyclopesoft.ServicesLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cyclopesoft.ServicesLayer.Validations
{
    public class ProductValidations 
    {
        public static ServiceResult AssertProductIsValid(ProductSaveDto product)
        {
            ServiceResult result = new ServiceResult();
            if (product.Bar_Code == null)
            {
                result.Success = false;
                result.Message = "Product Bar Code is missing";
                return result;
            }
            if (product.Name == null)
            {
                result.Success = false;
                result.Message = "Product Name is missing";
                return result;
            }
            if (product.Description == null)
            {
                result.Success = false;
                result.Message = "Product Description is missing";
                return result;
            }
            if (product.Distribution == null)
            {
                result.Success = false;
                result.Message = "Product Distribution is missing";
                return result;
            }
            if (product.Image == null)
            {
                result.Success = false;
                result.Message = "Product Image is missing";
                return result;
            }
            if (product.Cost_Price == null)
            {
                result.Success = false;
                result.Message = "Product Cost Price is missing";
                return result;
            }
            if (product.Gain == null)
            {
                result.Success = false;
                result.Message = "Product Gain is missing";
                return result;
            }
            if (product.Sale_Price == null)
            {
                result.Success = false;
                result.Message = "Product Sale_Price is missing";
                return result;
            }
            if (product.Wholesale_Price == null)
            {
                result.Success = false;
                result.Message = "Product Wholesale Price is missing";
                return result;
            }
            if (product.Minimum == null)
            {
                result.Success = false;
                result.Message = "Product Minimum is missing";
                return result;
            }
            if (product.Maximum == null)
            {
                result.Success = false;
                result.Message = "Product Maximum is missing";
                return result;
            }
            if (product.Stock == null)
            {
                result.Success = false;
                result.Message = "Product Stock is missing";
                return result;
            }
            return result;
        }
    }
}
