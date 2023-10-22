using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Chereghi_Razvan_Lab2.Models;

namespace Chereghi_Razvan_Lab2.Data
{
    public class Chereghi_Razvan_Lab2Context : DbContext
    {
        public Chereghi_Razvan_Lab2Context (DbContextOptions<Chereghi_Razvan_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Chereghi_Razvan_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Chereghi_Razvan_Lab2.Models.Publisher>? Publisher { get; set; }
    }
}
