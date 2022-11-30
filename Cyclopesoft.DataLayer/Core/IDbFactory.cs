using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cyclopesoft.DataLayer.Core
{
    public interface IDbFactory
    {
        DbContext GetDbContext { get; }
    }
}
