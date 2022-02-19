using ASPFinalProjectNETCORE.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPFinalProjectNETCORE.Data
{
    public class AppDbContext : DbContext
    {
        
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
