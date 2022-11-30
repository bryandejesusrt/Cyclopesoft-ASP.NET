using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Cyclopesoft.DataLayer.Core
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly DbContext dbContext;
        private readonly DbSet<TEntity> entities;
        public RepositoryBase(IDbFactory dbContext)
        {
            this.dbContext = dbContext.GetDbContext;
            this.entities = this.dbContext.Set<TEntity>();
        }
        public virtual void ExecuteProcedure(string procedureCommand, params SqlParameter[] sqlParams) => this.dbContext.Database.ExecuteSqlRaw(procedureCommand, sqlParams);
        public virtual bool Exists(Expression<Func<TEntity, bool>> filter) => this.entities.Any(filter);
        public virtual IEnumerable<TEntity> GetEntities() => this.entities.AsQueryable();
        public virtual TEntity GetEntity(int entityid) => this.entities.Find(entityid);
        public virtual void Remove(TEntity entity) => this.entities.Remove(entity);
        public virtual void Save(TEntity entity) => this.entities.Add(entity);
        public virtual void Save(TEntity[] entities) => this.entities.AddRange(entities);
        public virtual void Update(TEntity entity)
        {
            var entry = this.dbContext.Entry(entity);
            this.entities.Attach(entity);
            entry.State = EntityState.Modified;

        }
    }
}
