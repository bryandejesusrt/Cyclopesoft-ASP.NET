using Cyclopesoft.DataLayer.Context;
using Cyclopesoft.DataLayer.Entities;
using Cyclopesoft.DataLayer.Interface;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Cyclopesoft.DataLayer.Repository
{
    public class ClientRepository : IClientRepository
    {
        private readonly CyclopesoftContext context;
        private readonly ILogger<ClientRepository> logger;

        public ClientRepository(CyclopesoftContext context, ILogger<ClientRepository> logger)
        {
            this.context = context;
            this.logger = logger;
        }

        public void Remove(Client client)
        {
            try
            {
                context.Clients.Remove(client);
            }
            catch (Exception ex)
            {

                this.logger.LogError($"Error: {ex.Message}", ex.ToString());
            }
        }

        public void Save(Client client)
        {
            try
            {
                context.Clients.Add(client);
            }
            catch (Exception ex)
            {

                this.logger.LogError($"Error: {ex.Message}", ex.ToString());
            }
        }

        public void Update(Client client)
        {
            try
            {
                context.Clients.Update(client);
            }
            catch (Exception ex)
            {

                this.logger.LogError($"Error: {ex.Message}", ex.ToString());
            }
        }
        public Client GetClient(int fiscalId)
        {
            try
            {
                return context.Clients.Find(fiscalId);
            }
            catch (Exception ex)
            {
                this.logger.LogError($"Error: {ex.Message}", ex.ToString());
                return null;
            }
        } 
        
        public bool ExistClient(int fiscalId)
        {
            try
            {
                return context.Clients.Any(cl => cl.FiscalId == fiscalId); ;
            }
            catch (Exception ex)
            {
                this.logger.LogError($"Error: {ex.Message}", ex.ToString());
                return false;
            }
        }

        public IEnumerable<Client> GetClients()
        {
            return this.context.Clients;
        }
    }
    }
