using Microsoft.EntityFrameworkCore;
using VivaTest.Web.Entities;

namespace VivaTest.Web
{
    public class VivaContext : DbContext
    {
        public VivaContext(DbContextOptions option) : base(option)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBulder)
        {
            base.OnModelCreating(modelBulder);

            modelBulder.Entity<StudentTeacher>()
                .HasKey(st => new { st.StudentId, st.TeacherID });

            modelBulder.Entity<StudentTeacher>()
                .HasOne(s => s.Student)
                .WithMany(st => st.studentTeachers)
                .HasForeignKey(s => s.StudentId);

            modelBulder.Entity<StudentTeacher>()
                .HasOne(t => t.Teacher)
                .WithMany(st => st.studentTeachers)
                .HasForeignKey(t => t.TeacherID);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<StudentTeacher> StudentTeachers { get; set; }
    }
}