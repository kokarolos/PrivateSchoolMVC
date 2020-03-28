using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PrivateSchool.Entities.Concrete
{
    public class Course
    {
        public int CourseId { get; set; }
        [Required,MaxLength(50),MinLength(3)]
        public string Stream { get; set; }
        [Required]
        public Type Type { get; set; }
        [DataType(DataType.Date)]
        public DateTime? StartingDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime? EndingDate { get; set; }


        public virtual ICollection<Trainer> Trainers { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Assignment> Assignments { get; set; }
    }
}
