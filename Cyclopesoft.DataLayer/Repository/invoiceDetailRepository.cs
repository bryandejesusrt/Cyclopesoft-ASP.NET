using Cyclopesoft.DataLayer.Context;
using Cyclopesoft.DataLayer.Core;
using Cyclopesoft.DataLayer.Entities;
using Cyclopesoft.DataLayer.Interface;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Cyclopesoft.DataLayer.Repository
{
    public class InvoiceDetailRepository : Core.RepositoryBase<InvoiceDetail>, IInvoiceDetailRepository
    {
        private readonly CyclopesoftContext context;
        private readonly ILogger<InvoiceDetailRepository> logger;

        public InvoiceDetailRepository(CyclopesoftContext context, ILogger<InvoiceDetailRepository> logger) : base(new DbFactory.DbFactory(context))
        {
            this.context = context;
            this.logger = logger;
        }

        public IEnumerable<InvoiceDetail> GetInvoiceDetailsById(int id) => this.context.InvoiceDetails.Where(inv => inv.Id == id && !inv.Deleted);
        public override IEnumerable<InvoiceDetail> GetEntities() => base.GetEntities().Where(cd => !cd.Deleted);
        public override void Remove(InvoiceDetail invoiceDetail)
        {
            try
            {
                context.InvoiceDetails.Remove(invoiceDetail);
            }
            catch (Exception ex)
            {

                this.logger.LogError($"Error: {ex.Message}", ex.ToString());
            }
        }

        public override void Save(InvoiceDetail invoiceDetail)
        {
            try
            {
                context.InvoiceDetails.Add(invoiceDetail);
            }
            catch (Exception ex)
            {

                this.logger.LogError($"Error: {ex.Message}", ex.ToString());
            }
        }

        public override void Update(InvoiceDetail invoiceDetail)
        {
            try
            {
                context.InvoiceDetails.Update(invoiceDetail);
            }
            catch (Exception ex)
            {

                this.logger.LogError($"Error: {ex.Message}", ex.ToString());
            }
        }
    }
}
