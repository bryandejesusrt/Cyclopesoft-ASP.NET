using Cyclopesoft.ServicesLayer.Core;
using Cyclopesoft.ServicesLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cyclopesoft.ServicesLayer.Validations
{
   public class ClientValidation
    {
        public static ServiceResult AssertClientIsValid( ClientSaveDto client)
        {
            ServiceResult result = new ServiceResult();
            if (client.Id == null)
            {
                result.Success = false;
                result.Message = "Client Name is missing";
                return result;
            }
            if (client.Name == null)
            {
                result.Success = false;
                result.Message = "Client Name is missing";
                return result;
            }
            if (client.LastName == null)
            {
                result.Success = false;
                result.Message = "Client Name is missing";
                return result;
            }
            if (client.Phone == null)
            {
                result.Success = false;
                result.Message = "Client Name is missing";
                return result;
            }
            if (client.RNC == null)
            {
                result.Success = false;
                result.Message = "Client Name is missing";
                return result;
            }
            if (client.Email == null)
            {
                result.Success = false;
                result.Message = "Client Name is missing";
                return result;
            }
            if (client.Note == null)
            {
                result.Success = false;
                result.Message = "Client Name is missing";
                return result;
            }

            if (client.FiscalId == null)
            {
                result.Success = false;
                result.Message = "Client Name is missing";
                return result;
            }
            if (client.CreationDate == null)
            {
                result.Success = false;
                result.Message = "Client Name is missing";
                return result;
            }
            if (client.DeletedDate == null)
            {
                result.Success = false;
                result.Message = "Client Name is missing";
                return result;
            }
            if (client.UpdatedDate == null)
            {
                result.Success = false;
                result.Message = "Client Name is missing";
                return result;
            }
            return result;
        }
    }
}
