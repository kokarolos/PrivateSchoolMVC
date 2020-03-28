using PrivateSchool.Entities.Concrete;
using System.Data.Entity;


namespace PrivateSchool.Database
{
    public class m_Database:DbContext
    {
        public m_Database() : base("PrivateSchool") { }
        public DbSet<Student> Student { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Trainer> Trainer { get; set; }
        public DbSet<Assignment> Assignment { get; set; }


        //public DbSet<CourseStudents> CourseStudents { get; set; }
        //public DbSet<CourseTrainers> CourseTrainers { get; set; }
        //public DbSet<StudentCourseAssignemnts> StudentCourseAssignemnts { get; set; }
    }
}
