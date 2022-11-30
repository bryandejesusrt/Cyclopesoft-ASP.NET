using Cyclopesoft.DataLayer.Core;
using Cyclopesoft.DataLayer.Entities;
using System.Collections.Generic;

namespace Cyclopesoft.DataLayer.Interface
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        IEnumerable<User> GetUserById(int id);
    }
}
