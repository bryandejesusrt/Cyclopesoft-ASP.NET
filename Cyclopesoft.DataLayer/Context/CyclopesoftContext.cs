using Cyclopesoft.DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cyclopesoft.DataLayer.Context
{
    public partial class CyclopesoftContext : DbContext
    {
        public CyclopesoftContext() { }
        public CyclopesoftContext(DbContextOptions<CyclopesoftContext> options) : base(options) { }

        public DbSet<Client> Client { get; set; }
        public DbSet<InvoiceDetail> InvoiceDetail { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<User> User { get; set; }
    }
}
