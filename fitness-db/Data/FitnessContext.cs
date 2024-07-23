using fitness_db.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace fitness_db.Data
{
    public class FitnessContext : DbContext
    {
        public FitnessContext(DbContextOptions<FitnessContext> options) : base(options)
        {

        }



        public DbSet<User> users { get; set; }
        public DbSet<Nutrition> nutritions { get; set; }
        public DbSet<UserNutrition> userNutritions { get; set; }
        public DbSet<Workout> workouts { get; set; }
        public DbSet<UserWorkout> userWorkouts { get; set; }
        public DbSet<Progress> progresses { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserNutrition>().Property(u => u.UserNutritionID).UseIdentityColumn();
            modelBuilder.Entity<UserNutrition>().HasKey(un => new { un.UserNutritionID, un.UserID, un.NutritionID });
            modelBuilder.Entity<UserNutrition>()
                .HasOne(u => u.User)
                .WithMany(un => un.UserNutritions)
                .HasForeignKey(u => u.UserID);
            modelBuilder.Entity<UserNutrition>()
                .HasOne(n => n.Nutrition)
                .WithMany(un => un.UserNutritions)
                .HasForeignKey(n => n.NutritionID);


            modelBuilder.Entity<UserWorkout>().Property(u => u.UserWorkoutID).UseIdentityColumn();
            modelBuilder.Entity<UserWorkout>().HasKey(uw => new { uw.UserWorkoutID, uw.UserID, uw.WorkoutID });
            modelBuilder.Entity<UserWorkout>()
                .HasOne(u => u.User)
                .WithMany(uw => uw.UserWorkouts)
                .HasForeignKey(u => u.UserID);
            modelBuilder.Entity<UserWorkout>()
                .HasOne(w => w.Workout)
                .WithMany(uw => uw.UserWorkouts)
                .HasForeignKey(w => w.WorkoutID);


            modelBuilder.Entity<Progress>().Property(p => p.ProgressID).UseIdentityColumn();
            modelBuilder.Entity<Progress>().HasKey(p => new { p.ProgressID });
            modelBuilder.Entity<Progress>()
                .HasOne(u => u.User)
                .WithMany(p => p.Progresses)
                .HasForeignKey(u => u.UserID);
        }
    }
}
