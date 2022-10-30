using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ambrus_Andrea_Lab2.Models;

namespace Ambrus_Andrea_Lab2.Data
{
    public class Ambrus_Andrea_Lab2Context : DbContext
    {
        public Ambrus_Andrea_Lab2Context (DbContextOptions<Ambrus_Andrea_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Ambrus_Andrea_Lab2.Models.Book> Book { get; set; } 

        public DbSet<Ambrus_Andrea_Lab2.Models.Publisher> Publisher { get; set; } 

        public DbSet<Ambrus_Andrea_Lab2.Models.Author> Author { get; set; }
    }
}
