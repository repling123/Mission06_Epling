using Microsoft.EntityFrameworkCore;
using Mission06_Epling.Models;

namespace Mission06_Epling.Data
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options) { }

        public DbSet<Movie> Movies { get; set; }
    }
}
