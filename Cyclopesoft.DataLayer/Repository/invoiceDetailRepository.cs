using Cyclopesoft.DataLayer.Context;
using Cyclopesoft.DataLayer.Entities;
using Cyclopesoft.DataLayer.Interface;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cyclopesoft.DataLayer.Repository
{
    public class InvoiceDetailRepository : IInvoiceDetailRepository
    {
        private readonly CyclopesoftContext context;
        private readonly ILogger<InvoiceDetailRepository> logger;

        public InvoiceDetailRepository(CyclopesoftContext context, ILogger<InvoiceDetailRepository> logger)
        {
            this.context = context;
            this.logger = logger;
        }

        public void Remove(InvoiceDetail invoiceDetail)
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

        public void Save(InvoiceDetail invoiceDetail)
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

        public void Update(InvoiceDetail invoiceDetail)
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
        public bool ExistInvoiceDetail(int id)
        {
            try
            {
                return context.InvoiceDetails.Any(inv => inv.Id == id);
            }
            catch (Exception ex)
            {
                this.logger.LogError($"Error: {ex.Message}", ex.ToString());
                return false;
            }
        }
        public InvoiceDetail GetInvoiceDetails(int id)
        {
            try
            {
                return context.InvoiceDetails.Find(id);
            }
            catch (Exception ex)
            {

                this.logger.LogError($"Error: {ex.Message}", ex.ToString());
                return null;
            }
        }

        public IEnumerable<InvoiceDetail> GetInvoiceDetail()
        {
            
                return this.context.InvoiceDetails;
            
        }
    }
}
