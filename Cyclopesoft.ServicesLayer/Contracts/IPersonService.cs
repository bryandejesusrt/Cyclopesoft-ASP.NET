using Cyclopesoft.ServicesLayer.Core;
using Cyclopesoft.ServicesLayer.Dtos;
using Cyclopesoft.ServicesLayer.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cyclopesoft.ServicesLayer.Contracts
{
    public interface IPersonService
    {
        PersonResponse SavePerson(PersonSaveDto personSaveDto);
        PersonResponse UpdatePerson(PersonUpdateDto personSaveDto);
        PersonResponse RemovePerson(PersonRemoveDto personSaveDto);
        ServiceResult GetPerson();
        ServiceResult GetPersonInvoice();
    }
}
