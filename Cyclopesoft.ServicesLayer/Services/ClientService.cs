using Cyclopesoft.DataLayer.Entities;
using Cyclopesoft.DataLayer.Interface;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Cyclopesoft.ServicesLayer.Services
{
    public class ClientService : IClientRepository
    {
        public void ExecuteProcedure(string procedureCommand, params SqlParameter[] sqlParams)
        {
            throw new NotImplementedException();
        }

        public bool Exists(Expression<Func<Client, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Client> GetClientById(int fiscalId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Client> GetEntities()
        {
            throw new NotImplementedException();
        }

        public Client GetEntity(int entityid)
        {
            throw new NotImplementedException();
        }

        public void Remove(Client entity)
        {
            throw new NotImplementedException();
        }

        public void Save(Client entity)
        {
            throw new NotImplementedException();
        }

        public void Save(Client[] entities)
        {
            throw new NotImplementedException();
        }

        public void Update(Client entity)
        {
            throw new NotImplementedException();
        }
    }
}
