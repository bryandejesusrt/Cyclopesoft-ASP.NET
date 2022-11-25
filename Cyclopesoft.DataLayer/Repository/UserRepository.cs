using Cyclopesoft.DataLayer.Context;
using Cyclopesoft.DataLayer.Entities;
using Cyclopesoft.DataLayer.Interface;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cyclopesoft.DataLayer.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly CyclopesoftContext context;
        private readonly ILogger<InvoiceDetailRepository> logger;

        public UserRepository(CyclopesoftContext context, ILogger<InvoiceDetailRepository> logger)
        {
            this.context = context;
            this.logger = logger;
        }
        public void Remove(User user)
        {
            try
            {
                context.Users.Remove(user);
            }
            catch (Exception ex)
            {

                this.logger.LogError($"Error: {ex.Message}", ex.ToString());
            }
        }

        public void Save(User user)
        {
            try
            {
                context.Users.Add(user);
            }
            catch (Exception ex)
            {

                this.logger.LogError($"Error: {ex.Message}", ex.ToString());
            }
        }

        public void Update(User user)
        {
            try
            {
                context.Users.Update(user);
            }
            catch (Exception ex)
            {

                this.logger.LogError($"Error: {ex.Message}", ex.ToString());
            }
        }
        public User GetUser(int id)
        {
            try
            {
                return context.Users.Find(id);
            }
            catch (Exception ex)
            {

                this.logger.LogError($"Error: {ex.Message}", ex.ToString()); 
                return null;
            }
        }

        public bool ExistUser(int id)
        {
            try
            {
                return context.Users.Any(usr => usr.Id == id);
            }
            catch (Exception ex)
            {

                this.logger.LogError($"Error: {ex.Message}", ex.ToString());
                return false;
            }
        }

        public IEnumerable<User> GetUsers()
        {
            return this.context.Users;
        }
    }
}
