using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PrivateSchool.Entities.Concrete
{
    public class Assignment
    {
        public int AssignmentId { get; set; }
        [Required, MaxLength(60), MinLength(3)]
        public string Description { get; set; }
        [Required, DataType(DataType.Date)]
        public DateTime SubDate { get; set; }
        [Required, DataType(DataType.ImageUrl)]



        public virtual ICollection<Course> Courses { get; set; }
    }
}
