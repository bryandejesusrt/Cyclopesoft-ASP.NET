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
        public DbSet<Client> Clients { get; set; }
        public DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
