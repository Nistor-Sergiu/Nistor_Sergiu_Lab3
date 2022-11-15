using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nistoor_Sergiu_Lab2.Models;

namespace Nistoor_Sergiu_Lab2.Data
{
    public class Nistoor_Sergiu_Lab2Context : DbContext
    {
        public Nistoor_Sergiu_Lab2Context (DbContextOptions<Nistoor_Sergiu_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Nistoor_Sergiu_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Nistoor_Sergiu_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Nistoor_Sergiu_Lab2.Models.Author> Author { get; set; }

        public DbSet<Nistoor_Sergiu_Lab2.Models.Category> Category { get; set; }

        public DbSet<Nistoor_Sergiu_Lab2.Models.Member> Member { get; set; }

        public DbSet<Nistoor_Sergiu_Lab2.Models.Borrowing> Borrowing { get; set; }
    }
}
