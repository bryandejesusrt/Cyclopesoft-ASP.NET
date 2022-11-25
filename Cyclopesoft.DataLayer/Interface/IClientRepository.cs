using Cyclopesoft.DataLayer.Entities;
using System.Collections;
using System.Collections.Generic;

namespace Cyclopesoft.DataLayer.Interface
{
    public interface IClientRepository
    {
        public void Save(Client client);
        public void Update(Client client);
        public void Remove(Client client);
        public Client GetClient(int FiscalId);
        public bool ExistClient(int FiscalId);
        IEnumerable<Client> GetClients();
    }
}
