using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAppLiftItt.Models;

namespace WebAppLiftItt.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Workout> Workout { get; set; }
        public DbSet<Exercise> Exercise { get; set; }
        public DbSet<WorkoutExercise> WorkoutExercise { get; set; }
        public DbSet<Sets> Sets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Define relationships using Fluent API
            modelBuilder.Entity<Workout>()
                .HasMany(w => w.WorkoutExercise)
                .WithOne(we => we.Workout)
                .HasForeignKey(we => we.WorkoutId);

            modelBuilder.Entity<Exercise>();

            modelBuilder.Entity<WorkoutExercise>()
                .HasOne(we => we.Workout)
                .WithMany(w => w.WorkoutExercise)
                .HasForeignKey(we => we.WorkoutId);

            modelBuilder.Entity<WorkoutExercise>()
                .HasOne(we => we.Exercise)
                .WithMany()
                .HasForeignKey(we => we.ExerciseId);

            modelBuilder.Entity<Sets>();
        }
    }
}