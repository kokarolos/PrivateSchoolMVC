using System.Data.Entity;

namespace RelationshipExampleEntity
{
    class MyDatabase : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Trainer> Trainers { get; set; }

    }
}
