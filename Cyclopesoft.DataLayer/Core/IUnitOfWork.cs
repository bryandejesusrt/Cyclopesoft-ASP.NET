using System;
using System.Collections.Generic;
using System.Text;

namespace Cyclopesoft.DataLayer.Core
{
    public interface IUnitOfWork
    {
        public void BeginTransaction();
        public void RollbackTransaction();
        public void CommitTransaction();
        public void SaveChanges();
    }
}

