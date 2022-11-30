using Cyclopesoft.DataLayer.Core;
using Cyclopesoft.DataLayer.Entities;
using System.Collections;
using System.Collections.Generic;

namespace Cyclopesoft.DataLayer.Interface
{
    public interface IClientRepository : IRepositoryBase<Client>
    {
        IEnumerable<Client> GetClientById(int fiscalId);
    }
}
