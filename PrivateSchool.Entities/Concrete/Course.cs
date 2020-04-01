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
        [Display(Name = "Starting Date")]
        public DateTime? StartingDate { get; set; }
        
        [DataType(DataType.Date)]
        [Display(Name = "Ending Date")]
        public DateTime? EndingDate { get; set; }

        [Required(ErrorMessage = "Your Photo is mandatory"), DataType(DataType.ImageUrl)]
        [Display(Name = "Photo")]
        public string PhotoUrl { get; set; }

        public virtual ICollection<Trainer> Trainers { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Assignment> Assignments { get; set; }
    }
}
