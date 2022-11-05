using Cyclopesoft.DataLayer.Entities;

namespace Cyclopesoft.DataLayer.Interface
{
    public interface InvoiceRepository
    {
        void Save(Invoice invoice);
        void Delete(Invoice invoice);
        void Update(Invoice invoice);
        void Remove(Invoice invoice);
    }
}
