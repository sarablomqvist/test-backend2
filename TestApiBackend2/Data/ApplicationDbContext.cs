using Microsoft.EntityFrameworkCore;
using TestApiBackend2.Models;

namespace TestApiBackend2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

        public DbSet<Book> Books { get; set; }
    }
}
