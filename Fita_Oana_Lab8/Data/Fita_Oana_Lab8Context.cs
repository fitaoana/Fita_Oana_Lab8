using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Fita_Oana_Lab8.Models;

namespace Fita_Oana_Lab8.Data
{
    public class Fita_Oana_Lab8Context : DbContext
    {
        public Fita_Oana_Lab8Context (DbContextOptions<Fita_Oana_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Fita_Oana_Lab8.Models.Book> Book { get; set; }

        public DbSet<Fita_Oana_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Fita_Oana_Lab8.Models.Category> Category { get; set; }
    }
}
