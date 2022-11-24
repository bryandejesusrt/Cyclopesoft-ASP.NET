using Cyclopesoft.DataLayer.Entities;
using System.Collections.Generic;

namespace Cyclopesoft.DataLayer.Interface
{
    public interface IInvoiceDetailRepository 
    {
        void Save(InvoiceDetail invoiceDetail);
        void Update(InvoiceDetail invoiceDetail);
        void Remove(InvoiceDetail invoiceDetail);
        public InvoiceDetail GetInvoiceDetails(int id);
        public bool ExistInvoiceDetail(int id);
        IEnumerable<InvoiceDetail> GetInvoiceDetail();
    }
}
