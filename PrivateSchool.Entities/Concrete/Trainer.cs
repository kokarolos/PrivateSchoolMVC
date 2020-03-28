using PrivateSchool.Entities.Intermediaries;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PrivateSchool.Entities.Concrete
{
    public class Trainer
    {
        public int TrainerId { get; set; }
        [Required, MaxLength(50), MinLength(3)]
        public string FirstName { get; set; }
        [Required, MaxLength(50), MinLength(3)]
        public string LastName { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
