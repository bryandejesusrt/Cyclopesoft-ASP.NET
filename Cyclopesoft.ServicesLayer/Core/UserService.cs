using Cyclopesoft.ServicesLayer.Contracts;
using Cyclopesoft.ServicesLayer.Dtos;
using Cyclopesoft.ServicesLayer.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cyclopesoft.ServicesLayer.Core
{
    public class UserService : IUserService
    {
        public ServiceResult GetUser()
        {
            throw new NotImplementedException();
        }

        public ServiceResult GetUserInvoice()
        {
            throw new NotImplementedException();
        }

        public UserResponse RemoveUser(UserRemoveDto userSaveDto)
        {
            throw new NotImplementedException();
        }

        public UserResponse SaveUser(UserSaveDto userSaveDto)
        {
            throw new NotImplementedException();
        }

        public UserResponse UpdateUser(UserUpdateDto userSaveDto)
        {
            throw new NotImplementedException();
        }
    }
}
