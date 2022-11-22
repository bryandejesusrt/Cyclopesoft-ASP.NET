using Cyclopesoft.DataLayer.Entities;

namespace Cyclopesoft.DataLayer.Interface
{
    public interface IUserRepository
    {
        void Save(User user);
        void Update(User user);
        void Remove(User user);
        public User GetUser(int id);
        public bool ExistUser(int id);
    }
}
