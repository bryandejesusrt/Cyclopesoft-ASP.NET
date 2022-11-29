using Cyclopesoft.ServicesLayer.Core;
using Cyclopesoft.ServicesLayer.Dtos;
using Cyclopesoft.ServicesLayer.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cyclopesoft.ServicesLayer.Contracts
{
    public interface IUserService
    {
        UserResponse SaveUser(UserSaveDto userSaveDto);
        UserResponse UpdateUser(UserUpdateDto userSaveDto);
        UserResponse RemoveUser(UserRemoveDto userSaveDto);
        ServiceResult GetUser();
        ServiceResult GetUserInvoice();
    }
}
