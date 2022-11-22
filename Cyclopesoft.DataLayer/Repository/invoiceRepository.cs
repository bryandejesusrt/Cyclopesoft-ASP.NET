using Cyclopesoft.DataLayer.Context;
using Cyclopesoft.DataLayer.Entities;
using Cyclopesoft.DataLayer.Interface;
using Microsoft.EntityFrameworkCore.Internal;
using System.Linq;

namespace Cyclopesoft.DataLayer.Repository
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private readonly CyclopesoftContext context;
        public InvoiceRepository(CyclopesoftContext context)
        {
            this.context = context;
        }
        public void Remove(Invoice invoice)
        {
            context.Invoices.Remove(invoice);
        }

        public void Save(Invoice invoice)
        {
            context.Invoices.Add(invoice);
        }

        public void Update(Invoice invoice)
        {
            context.Invoices.Update(invoice);
        }
        public Invoice GetInvoice(int id) => context.Invoices.Find(id);
        public bool ExistInvoice(int id) => context.Invoices.Any(inv => inv.Id == id);
    }
}
