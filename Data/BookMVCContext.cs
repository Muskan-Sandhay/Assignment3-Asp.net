using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookMVC.Models;

namespace BookMVC.Data
{
    public class BookMVCContext : DbContext
    {
        public BookMVCContext (DbContextOptions<BookMVCContext> options)
            : base(options)
        {
        }

        public DbSet<BookMVC.Models.Books> Books { get; set; } = default!;
    }
}
