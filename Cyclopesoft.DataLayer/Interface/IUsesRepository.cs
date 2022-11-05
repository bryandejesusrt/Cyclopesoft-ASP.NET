using Cyclopesoft.DataLayer.Entities;

namespace Cyclopesoft.DataLayer.Interface
{
    public interface IUsesRepository
    {
        void Save(User uses);
        void Delete(User uses);
        void Update(User uses);
        void Remove(User uses);
    }
}
