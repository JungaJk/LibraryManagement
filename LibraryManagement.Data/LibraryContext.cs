using Microsoft.EntityFrameworkCore;
using System;

namespace LibraryManagement.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions options) : base(options) { }

        public DbSet<Patron> Patrons { get; set; }
    }
}
