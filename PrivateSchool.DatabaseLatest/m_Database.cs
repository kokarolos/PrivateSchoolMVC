using PrivateSchool.Entities.Concrete;
using PrivateSchool.Entities.Intermediaries;
using System.Data.Entity;

namespace PrivateSchool.DatabaseLatest
{
    public class m_Database:DbContext
    {
        public m_Database():base("Connection")
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentAssignments> StudentAssignments { get; set; }
    }
}
