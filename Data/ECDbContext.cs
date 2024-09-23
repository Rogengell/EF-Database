using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFDatabase.Model;
using Microsoft.EntityFrameworkCore;

namespace EFDatabase.Data
{
    public class ECDbContext : DbContext
    {
        public ECDbContext(DbContextOptions<ECDbContext> options) : base(options) { }

        public DbSet<Products>? product { get; set; }
    }
}