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
        public DbSet<User> Users { get; set; }
        public DbSet<UserExercise> UserExercises { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Exercise>()
                .Property(e => e.ExerciseType)
                .HasConversion<string>();

            modelBuilder.Entity<Exercise>()
                .Property(e => e.MuscleGroup)
                .HasConversion<string>();

            modelBuilder.Entity<UserExercise>()
               .HasOne(ue => ue.Exercise)  // Navigation property
               .WithMany()  // Exercise can be associated with many UserExercises
               .HasForeignKey(ue => ue.ExerciseId);

            modelBuilder.Entity<UserExercise>()
                .HasOne(ue => ue.User)
                .WithMany() // User can be associated with many UserExercises
                .HasForeignKey(ue => ue.UserId);
        }
    }
}
