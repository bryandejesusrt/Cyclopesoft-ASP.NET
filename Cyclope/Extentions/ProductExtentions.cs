using Cyclopesoft.DataLayer.Entities;
using Cyclopesoft.ServicesLayer.Models;
using System.Collections.Generic;
using System.Linq;

namespace Cyclope.Extentions
{
    public static class ProductExtentions
    {
        public static IEnumerable<Cyclopesoft.Model.Product> ConvertProductModelToModel(this List<ProductModel> productModels)
        {
            var products = productModels.Select(prd => new Cyclopesoft.Model.Product()
            {
                Id = prd.Id,
                Bar_Code = prd.Bar_Code,
                Name = prd.Name,
                Description = prd.Description,
                Distribution = prd.Distribution,
                Image = prd.Image,
                Cost_Price = prd.Cost_Price,
                Gain = prd.Gain,
                Sale_Price = prd.Sale_Price,
                Wholesale_Price = prd.Wholesale_Price,
                Minimum = prd.Minimum,
                Maximum = prd.Maximum,
                Stock = prd.Stock,

            }).ToList();

            return products;
        }
    }
}
