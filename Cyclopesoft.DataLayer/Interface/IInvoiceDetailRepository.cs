using Cyclopesoft.DataLayer.Core;
using Cyclopesoft.DataLayer.Entities;
using System.Collections.Generic;

namespace Cyclopesoft.DataLayer.Interface
{
    public interface IInvoiceDetailRepository : IRepositoryBase<InvoiceDetail>
    {
        IEnumerable<InvoiceDetail> GetInvoiceDetailsById(int id);
    }
}
