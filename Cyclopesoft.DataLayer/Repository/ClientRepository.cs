using Cyclopesoft.DataLayer.Context;
using Cyclopesoft.DataLayer.Entities;
using Cyclopesoft.DataLayer.Interface;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Cyclopesoft.DataLayer.Repository
{
    public class ClientRepository : Core.RepositoryBase<Client>, IClientRepository
    {
        private readonly CyclopesoftContext context;
        private readonly ILogger<ClientRepository> logger;

        public ClientRepository(CyclopesoftContext context, ILogger<ClientRepository> logger) : base(new DbFactory.DbFactory(context))
        {
            this.context = context;
            this.logger = logger;
        }

        IEnumerable<Client> IClientRepository.GetClientById(int fiscalId) => this.context.Client.Where(clnt => clnt.Id == fiscalId);
        public override IEnumerable<Client> GetEntities() => context.Client;
        public override void Remove(Client client)
        {
            try
            {
                context.Client.Remove(client);
            }
            catch (Exception ex)
            {

                this.logger.LogError($"Error: {ex.Message}", ex.ToString());
            }
        }

        public override void Save(Client client)
        {
            try
            {
                context.Client.Add(client);
            }
            catch (Exception ex)
            {

                this.logger.LogError($"Error: {ex.Message}", ex.ToString());
            }
        }

        public override void Update(Client client)
        {
            try
            {
                context.Client.Update(client);
            }
            catch (Exception ex)
            {

                this.logger.LogError($"Error: {ex.Message}", ex.ToString());
            }
        }
        
    }
    }
