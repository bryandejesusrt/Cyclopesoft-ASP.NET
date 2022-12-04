using Cyclopesoft.DataLayer.Context;
using Cyclopesoft.DataLayer.Entities;
using Cyclopesoft.DataLayer.Interface;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cyclopesoft.DataLayer.Repository
{
    public class UserRepository : Core.RepositoryBase<User>, IUserRepository
    {
        private readonly CyclopesoftContext context;
        private readonly ILogger<InvoiceDetailRepository> logger;

        public UserRepository(CyclopesoftContext context, ILogger<InvoiceDetailRepository> logger) : base(new DbFactory.DbFactory(context))
        {
            this.context = context;
            this.logger = logger;
        }

        IEnumerable<User> IUserRepository.GetUserById(int id) => this.context.User.Where(usr => usr.Id == id);
        public override IEnumerable<User> GetEntities() => context.User;
        public override void Remove(User user)
        {
            try
            {
                context.User.Remove(user);
            }
            catch (Exception ex)
            {

                this.logger.LogError($"Error: {ex.Message}", ex.ToString());
            }
        }

        public override void Save(User user)
        {
            try
            {
                context.User.Add(user);
            }
            catch (Exception ex)
            {

                this.logger.LogError($"Error: {ex.Message}", ex.ToString());
            }
        }

        public override void Update(User user)
        {
            try
            {
                context.User.Update(user);
            }
            catch (Exception ex)
            {

                this.logger.LogError($"Error: {ex.Message}", ex.ToString());
            }
        }
    }
}
