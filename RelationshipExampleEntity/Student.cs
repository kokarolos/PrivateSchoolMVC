using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace RelationshipExampleEntity
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public virtual ICollection<Course> Courses { get; set; }

    }
}
