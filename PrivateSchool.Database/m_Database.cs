using PrivateSchool.Entities.Concrete;
using PrivateSchool.Entities.Intermediaries;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;


namespace PrivateSchool.Database
{
    public class m_Database:DbContext
    {
        public m_Database() : base("PrivateSchool") { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<StudentAssignments> StudentAssignments { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentAssignments>()
                .HasKey(x => new { x.StudentId, x.AssignmentId });
        }

        //public DbSet<CourseStudents> CourseStudents { get; set; }
        //public DbSet<CourseTrainers> CourseTrainers { get; set; }
        //public DbSet<StudentCourseAssignemnts> StudentCourseAssignemnts { get; set; }
    }
}
