using Cyclopesoft.DataLayer.Entities;

namespace Cyclopesoft.DataLayer.Interface
{
    public interface IInvoiceDetailRepository 
    {
        void Save(InvoiceDetail invoiceDetail);
        void Update(InvoiceDetail invoiceDetail);
        void Remove(InvoiceDetail invoiceDetail);
        public InvoiceDetail GetInvoiceDetails(int id);
        public bool ExistInvoiceDetail(int id);
    }
}
