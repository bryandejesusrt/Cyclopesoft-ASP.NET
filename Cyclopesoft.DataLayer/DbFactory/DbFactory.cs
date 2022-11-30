using Cyclopesoft.DataLayer.Context;
using Cyclopesoft.DataLayer.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cyclopesoft.DataLayer.DbFactory
{
    public class DbFactory : IDbFactory, IDisposable
    {
        private readonly DbContext context;
        private bool isDisposed;

        DbContext IDbFactory.GetDbContext => this.context;

        public DbFactory(CyclopesoftContext context) => this.context = context;
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }
        private void Dispose(bool disposing)
        {
            if(!isDisposed && disposing)
            {
                if (this.context != null)
                {
                    this.context.Dispose();
                }
            }
            isDisposed = true;
        }
    }
}
