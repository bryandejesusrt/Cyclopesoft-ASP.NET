using Cyclopesoft.ServicesLayer.Core;
using Cyclopesoft.ServicesLayer.Dtos;
using Cyclopesoft.ServicesLayer.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cyclopesoft.ServicesLayer.Contracts
{
    public interface IUserService : IBaseService
    {
        UserResponse SaveUser(UserSaveDto userSaveDto);
        UserResponse UpdateUser(UserUpdateDto userUpdateDto);
        UserResponse RemoveUser(UserRemoveDto userRemoveDto);
      
    }
}
