using System.Collections.Generic;

namespace RelationshipExampleEntity
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public string Stream { get; set; }
        public virtual Assignment Assignment { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Trainer> Trainers { get; set; }

    }
}
