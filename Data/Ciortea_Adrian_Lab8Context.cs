using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ciortea_Adrian_Lab8.Models;

namespace Ciortea_Adrian_Lab8.Data
{
    public class Ciortea_Adrian_Lab8Context : DbContext
    {
        public Ciortea_Adrian_Lab8Context (DbContextOptions<Ciortea_Adrian_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Ciortea_Adrian_Lab8.Models.Book> Book { get; set; }

        public DbSet<Ciortea_Adrian_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Ciortea_Adrian_Lab8.Models.Category> Category { get; set; }
    }
}
