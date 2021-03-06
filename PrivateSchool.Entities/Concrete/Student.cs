﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PrivateSchool.Entities.CustomValidation;
using PrivateSchool.Entities.Intermediaries;

namespace PrivateSchool.Entities.Concrete
{
    public class Student 
    {
        public int StudentId { get; set; }

        [Required(ErrorMessage = "The Firstname is mandatory"), MaxLength(15), MinLength(2)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "The Surname is mandatory"), MaxLength(15), MinLength(2)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "The date value is mandatory"), DataType(DataType.Date)]
        [Display(Name = "Date Of Birth")]
        public DateTime DateOfBirth { get; set; }

        [CustomValidation(typeof(ValidationMethods), "ValidateGreaterOrEqualToZero")]
        [Display(Name = "Fees")]
        public double TuitionFees { get; set; }

        [Required(ErrorMessage = "Your Email is mandatory"), DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Your Photo is mandatory"), DataType(DataType.ImageUrl)]
        [Display(Name = "Photo")]
        public string PhotoUrl { get; set; }
        [MaxLength(10),DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone")]
        public string PhoneNumber { get; set; }

        [NotMapped]
        public int Age
        {
            get { return DateTime.Now.Year - this.DateOfBirth.Year; }

        }

        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<StudentAssignments> StudentAssignments { get; set; }

    }
}
