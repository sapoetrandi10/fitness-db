﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using fitness_db.Data;

#nullable disable

namespace fitness_db.Migrations
{
    [DbContext(typeof(FitnessContext))]
    partial class FitnessContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("fitness_db.Models.Nutrition", b =>
                {
                    b.Property<int>("NutritionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NutritionID"), 1L, 1);

                    b.Property<float>("Calories")
                        .HasColumnType("real");

                    b.Property<float>("Carbs")
                        .HasColumnType("real");

                    b.Property<float>("Fat")
                        .HasColumnType("real");

                    b.Property<string>("NutritionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Protein")
                        .HasColumnType("real");

                    b.HasKey("NutritionID");

                    b.ToTable("nutritions");
                });

            modelBuilder.Entity("fitness_db.Models.Progress", b =>
                {
                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<float>("CaloriesBurned")
                        .HasColumnType("real");

                    b.Property<float>("CaloriesConsumed")
                        .HasColumnType("real");

                    b.Property<DateTime>("ProgressDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProgressID")
                        .HasColumnType("int");

                    b.Property<float>("Weight")
                        .HasColumnType("real");

                    b.HasKey("UserID");

                    b.ToTable("progresses");
                });

            modelBuilder.Entity("fitness_db.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Height")
                        .HasColumnType("real");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Weight")
                        .HasColumnType("real");

                    b.HasKey("UserID");

                    b.ToTable("users");
                });

            modelBuilder.Entity("fitness_db.Models.UserNutrition", b =>
                {
                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<int>("NutritionID")
                        .HasColumnType("int");

                    b.Property<DateTime>("UserNutritionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserNutritionID")
                        .HasColumnType("int");

                    b.HasKey("UserID", "NutritionID");

                    b.HasIndex("NutritionID");

                    b.ToTable("userNutritions");
                });

            modelBuilder.Entity("fitness_db.Models.UserWorkout", b =>
                {
                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<int>("WorkoutID")
                        .HasColumnType("int");

                    b.Property<DateTime>("UserWorkoutDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserWorkoutID")
                        .HasColumnType("int");

                    b.HasKey("UserID", "WorkoutID");

                    b.HasIndex("WorkoutID");

                    b.ToTable("userWorkouts");
                });

            modelBuilder.Entity("fitness_db.Models.Workout", b =>
                {
                    b.Property<int>("WorkoutID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WorkoutID"), 1L, 1);

                    b.Property<float>("CaloriesBurned")
                        .HasColumnType("real");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("WorkoutName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WorkoutID");

                    b.ToTable("workouts");
                });

            modelBuilder.Entity("fitness_db.Models.Progress", b =>
                {
                    b.HasOne("fitness_db.Models.User", "User")
                        .WithMany("Progresses")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("fitness_db.Models.UserNutrition", b =>
                {
                    b.HasOne("fitness_db.Models.Nutrition", "Nutrition")
                        .WithMany("UserNutritions")
                        .HasForeignKey("NutritionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("fitness_db.Models.User", "User")
                        .WithMany("UserNutritions")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Nutrition");

                    b.Navigation("User");
                });

            modelBuilder.Entity("fitness_db.Models.UserWorkout", b =>
                {
                    b.HasOne("fitness_db.Models.User", "User")
                        .WithMany("UserWorkouts")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("fitness_db.Models.Workout", "Workout")
                        .WithMany("UserWorkouts")
                        .HasForeignKey("WorkoutID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");

                    b.Navigation("Workout");
                });

            modelBuilder.Entity("fitness_db.Models.Nutrition", b =>
                {
                    b.Navigation("UserNutritions");
                });

            modelBuilder.Entity("fitness_db.Models.User", b =>
                {
                    b.Navigation("Progresses");

                    b.Navigation("UserNutritions");

                    b.Navigation("UserWorkouts");
                });

            modelBuilder.Entity("fitness_db.Models.Workout", b =>
                {
                    b.Navigation("UserWorkouts");
                });
#pragma warning restore 612, 618
        }
    }
}
