using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PrivateSchool.Entities.CustomValidation;

namespace PrivateSchool.Entities.Concrete
{
    public class Student
    {
        public int StudentId { get; set; }
        [Required, MaxLength(10), MinLength(2)]
        public string FirstName { get; set; }
        [Required, MaxLength(10), MinLength(2)]
        public string LastName { get; set; }
        [Required]
        public DateTime? DateOfBirth { get; set; }

        [CustomValidation(typeof(ValidationMethods), "ValidateGreaterOrEqualToZero")]
        public double TuitionFees { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
