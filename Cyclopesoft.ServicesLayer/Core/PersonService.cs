using Cyclopesoft.ServicesLayer.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cyclopesoft.ServicesLayer.Core
{
    public class PersonService : IPersonService
    {
        public ServiceResult GetPerson()
        {
            throw new NotImplementedException();
        }

        public ServiceResult GetPersonInvoice()
        {
            throw new NotImplementedException();
        }

        public PersonResponse RemovePerson(PersonRemoveDto personSaveDto)
        {
            throw new NotImplementedException();
        }

        public PersonResponse SavePerson(PersonSaveDto personSaveDto)
        {
            throw new NotImplementedException();
        }

        public PersonResponse UpdatePerson(PersonUpdateDto personSaveDto)
        {
            throw new NotImplementedException();
        }
    }
}
