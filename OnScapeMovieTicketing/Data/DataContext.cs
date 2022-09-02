using Microsoft.EntityFrameworkCore;
using OnScapeMovieTicketing.Models;

namespace OnScapeMovieTicketing.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}
