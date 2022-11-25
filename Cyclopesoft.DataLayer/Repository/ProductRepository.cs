using Cyclopesoft.DataLayer.Context;
using Cyclopesoft.DataLayer.Entities;
using Cyclopesoft.DataLayer.Interface;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cyclopesoft.DataLayer.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly CyclopesoftContext context;
        private readonly ILogger<InvoiceDetailRepository> logger;

        public ProductRepository(CyclopesoftContext context, ILogger<InvoiceDetailRepository> logger)
        {
            this.context = context;
            this.logger = logger;
        }
        public void Remove(Product product)
        {
            try
            {
                context.Products.Remove(product);
            }
            catch (Exception ex)
            {

                this.logger.LogError($"Error: {ex.Message}", ex.ToString());
            }
        }

        public void Save(Product product)
        {
            try
            {
                context.Products.Add(product);
            }
            catch (Exception ex)
            {

                this.logger.LogError($"Error: {ex.Message}", ex.ToString());
            }
        }

        public void Update(Product product)
        {
            try
            {
                context.Products.Update(product);
            }
            catch (Exception ex)
            {

                this.logger.LogError($"Error: {ex.Message}", ex.ToString());
            }
        }
        public Product GetProduct(int id)
        {
            try
            {
                return context.Products.Find(id);
            }
            catch (Exception ex)
            {
                this.logger.LogError($"Error: {ex.Message}", ex.ToString());
                return null;
            }
        }

        public bool ExistProduct(int id)
        {
            try
            {
                return context.Products.Any(prd => prd.Id == id);
            }
            catch (Exception ex)
            {
                this.logger.LogError($"Error: {ex.Message}", ex.ToString());
                return false;
            }
        }

        public IEnumerable<Product> GetProducts()
        {
            return this.context.Products;
        }
    }
}
