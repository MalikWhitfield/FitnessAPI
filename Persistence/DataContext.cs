using Microsoft.EntityFrameworkCore;
using Domain;
using Domain.Models;
using Domain.Enums;
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

            modelBuilder.Entity<Exercise>()
                .Property(e => e.MuscleGroup)
                .HasConversion<string>();
        }
    }
}
