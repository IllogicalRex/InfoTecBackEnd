using Microsoft.EntityFrameworkCore;
using System;

namespace InfoTecBackEnd.Models
{
    public partial class ResourceDBContext: DbContext
    {
        private readonly string connection;
        public ResourceDBContext(string connectionLoc)
        {
            connection = connectionLoc;
        }
        public ResourceDBContext(DbContextOptions<ResourceDBContext> options)
            : base(options) {}

        public DbSet<BankProjectModel> ProjectBank { get; set; }

    }
}