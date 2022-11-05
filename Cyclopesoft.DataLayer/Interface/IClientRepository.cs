using Cyclopesoft.DataLayer.Entities;

namespace Cyclopesoft.DataLayer.Interface
{
    public interface IClientRepository
    {
        void Save(Client client);
        void Delete(Client client);
        void Update(Client client);
        void Remove (Client client);
    }
}
