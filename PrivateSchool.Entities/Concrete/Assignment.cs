using PrivateSchool.Entities.Intermediaries;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PrivateSchool.Entities.Concrete
{
    public class Assignment
    {
        public int AssignmentId { get; set; }
        [Required, MaxLength(60), MinLength(3)]
        [Display(Name = "Desc")]
        public string Description { get; set; }
        [Required, DataType(DataType.Date)]
        [Display(Name = "Due To")]
        public DateTime SubDate { get; set; }


        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<StudentAssignments> StudentAssignments { get; set; }
    }
}
