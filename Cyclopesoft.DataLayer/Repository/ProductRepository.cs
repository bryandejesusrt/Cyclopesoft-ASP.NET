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

        IEnumerable<Product> IProductRepository.GetProductById(int id) => this.context.Products.Where(prd => prd.Id == id);
        public override IEnumerable<Product> GetEntities() => base.GetEntities().Where(cd => !cd.Deleted);
        public override void Remove(Product product)
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

        public override void Save(Product product)
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

        public override void Update(Product product)
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
    }
}
