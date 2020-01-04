using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleData.Core
{
    public class SampleDbContext : DbContext
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public SampleDbContext(DbContextOptions<SampleDbContext> dbContextOptions)
            :base(dbContextOptions)
        {

        }

        public SampleDbContext(string connectionString,string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if (!dbContextOptionsBuilder.IsConfigured)
            {
                
                dbContextOptionsBuilder.UseSqlServer(_connectionString, m => m.MigrationsAssembly(_migrationAssemblyName));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<Student>()
                .HasMany(s => s.StudentCourses)
                .WithOne(sc => sc.Student)
                .HasForeignKey(sc => sc.StudentId);

            modelBuilder.Entity<Course>()
                .HasMany(c => c.StudentCourses)
                .WithOne(sc => sc.Course)
                .HasForeignKey(sc => sc.CourseId);

            modelBuilder.Entity<StudentCourse>().HasKey(sc => new { sc.StudentId, sc.CourseId });
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
    }
}
