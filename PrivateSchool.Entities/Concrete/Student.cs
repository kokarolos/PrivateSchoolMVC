using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PrivateSchool.Entities.CustomValidation;

namespace PrivateSchool.Entities.Concrete
{
    public class Student
    {
        public int StudentId { get; set; }
        [Required(ErrorMessage = "The Firstname is mandatory"), MaxLength(10), MinLength(2)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "The Surname is mandatory"), MaxLength(10), MinLength(2)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "The date value is mandatory"), DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }

        [CustomValidation(typeof(ValidationMethods), "ValidateGreaterOrEqualToZero")]
        public double TuitionFees { get; set; }
        [Required(ErrorMessage = "Your Email is mandatory"), DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Your Photo is mandatory"), DataType(DataType.ImageUrl)]
        public string PhotoUrl { get; set; }
        [MaxLength(10),DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
