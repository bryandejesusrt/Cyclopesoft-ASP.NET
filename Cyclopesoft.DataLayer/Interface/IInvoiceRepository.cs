using Cyclopesoft.DataLayer.Core;
using Cyclopesoft.DataLayer.Entities;
using System.Collections.Generic;

namespace Cyclopesoft.DataLayer.Interface
{
    public interface IInvoiceRepository : IRepositoryBase<Invoice>
    {
        IEnumerable<Invoice> GetInvoiceById(int id);
    }
}
