using Cyclopesoft.ServicesLayer.Core;
using Cyclopesoft.ServicesLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cyclopesoft.ServicesLayer.Validations
{
    public class UserValidations
    {
        public  static ServiceResult AssertUserIsValid(UserSaveDto user)
        {
            ServiceResult result = new ServiceResult();
            if (user.Name == null)
            {
                result.Success = false;
                result.Message = "User serial is missing";
                return result;
            }
            if (user.LastName == null)
            {
                result.Success = false;
                result.Message = "Invoice RNC is missing";
                return result;
            }
            if (user.Email == null)
            {
                result.Success = false;
                result.Message = "Invoice Expiration Date is missing";
                return result;
            }
            if (user.Phone == null)
            {
                result.Success = false;
                result.Message = "Invoice Payment Type is missing";
                return result;
            }
            if (user.BusinessName == null)
            {
                result.Success = false;
                result.Message = "Invoice BusinessName is missing";
                return result;
            }
            if (user.DirectIn == null)
            {
                result.Success = false;
                result.Message = "Invoice Directin is missing";
                return result;
            }
            if (user.CreationUser == null)
            {
                result.Success = false;
                result.Message = "Invoice CreationUser is missing";
                return result;
            }
            if (user.CreationDate == null)
            {
                result.Success = false;
                result.Message = "Invoice CreationDate is missing";
                return result;
            }
            if(user.Password == null) 
            {
                result.Success = false;
                result.Message = "User Password is missing";
                return result;
            }
            if(user.Rol == null)
            {
                result.Success = false;
                result.Message = "User Rol is missing";
                return result;
            }
            if(user.Last_Connection == null) 
            {
                result.Success = false;
                result.Message = "User Last_Connection is missing";
                return result;
            }
            return result;
        }
    }
}
