using Cyclopesoft.DataLayer.Context;
using Cyclopesoft.DataLayer.Entities;
using Cyclopesoft.DataLayer.Interface;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Cyclopesoft.DataLayer.Repository
{
    public class InvoiceRepository : Core.RepositoryBase<Invoice>, IInvoiceRepository
    {
        private readonly CyclopesoftContext context;
        private readonly ILogger<InvoiceRepository> logger;
        public InvoiceRepository(CyclopesoftContext context, ILogger<InvoiceRepository> logger) : base(new DbFactory.DbFactory(context))
        {
            this.context = context;
            this.logger = logger;
        }
        public IEnumerable<Invoice> GetInvoiceById(int id) => this.context.Invoice.Where(inv => inv.Id == id && !inv.Deleted);
        public override IEnumerable<Invoice> GetEntities() => context.Invoice;
        public override void Remove(Invoice invoice)
        {
            try
            {
                context.Invoice.Remove(invoice);
            }
            catch (Exception ex)
            {
                this.logger.LogError($"Error: {ex.Message}", ex.ToString());
            }
            
        }

        public override void Save(Invoice invoice)
        {
            try
            {
                context.Invoice.Add(invoice);
            }
            catch (Exception ex)
            {
                this.logger.LogError($"Error: {ex.Message}", ex.ToString());
            }
        }

        public override void Update(Invoice invoice)
        {
            try
            {
                context.Invoice.Update(invoice);
            }
            catch (Exception ex)
            {
                this.logger.LogError($"Error: {ex.Message}", ex.ToString());
            }
        }
    }
}
