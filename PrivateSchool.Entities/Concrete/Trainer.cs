using PrivateSchool.Entities.Intermediaries;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PrivateSchool.Entities.Concrete
{
    public class Trainer
    {
        public int TrainerId { get; set; }
        [Required(ErrorMessage = "Your FirstName is mandatory"), MaxLength(50), MinLength(3)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Your LastName is mandatory"), MaxLength(50), MinLength(3)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "We are not slaves,give that man $"),DataType(DataType.Currency),Range(1000,10000)]
        public int Salary { get; set; }
        [Required(ErrorMessage = "Your Email is mandatory"), DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Your Photo is mandatory"), DataType(DataType.ImageUrl)]
        [Display(Name = "Photo")]
        public string PhotoUrl { get; set; }
        [MaxLength(10), DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone")]
        public string PhoneNumber { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}
