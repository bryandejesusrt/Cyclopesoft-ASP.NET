using Cyclopesoft.DataLayer.Context;
using Cyclopesoft.DataLayer.Entities;
using Cyclopesoft.DataLayer.Interface;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cyclopesoft.DataLayer.Repository
{
    public class ProductRepository : Core.RepositoryBase<Product>, IProductRepository
    {
        private readonly CyclopesoftContext context;
        private readonly ILogger<InvoiceDetailRepository> logger;

        public ProductRepository(CyclopesoftContext context, ILogger<InvoiceDetailRepository> logger) : base(new DbFactory.DbFactory(context))
        {
            this.context = context;
            this.logger = logger;
        }

        IEnumerable<Product> IProductRepository.GetProductById(int id) => this.context.Product.Where(prd => prd.Id == id);
        public override IEnumerable<Product> GetEntities() => context.Product;
        public override void Remove(Product product)
        {
            try
            {
                context.Product.Remove(product);
            }
            catch (Exception ex)
            {

                this.logger.LogError($"Error: {ex.Message}", ex.ToString());
            }
        }

        public override void Save(Product product)
        {
            try
            {
                context.Product.Add(product);
            }
            catch (Exception ex)
            {

                this.logger.LogError($"Error: {ex.Message}", ex.ToString());
            }
        }

        public override void Update(Product product)
        {
            try
            {
                context.Product.Update(product);
            }
            catch (Exception ex)
            {

                this.logger.LogError($"Error: {ex.Message}", ex.ToString());
            }
        }
    }
}
