using Microsoft.EntityFrameworkCore;
using Domain;
using Domain.Models;
namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Exercise> Exercises { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Exercise>()
                .Property(e => e.ExerciseType)
                .HasConversion<string>();
        }
    }
}
