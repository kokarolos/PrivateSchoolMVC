using PrivateSchool.Entities.Concrete;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrivateSchool.Entities.Intermediaries
{
    public class CourseTrainers
    {
        [Key, Column(Order = 1)]
        public int CourseId { get; set; }

        [Key, Column(Order = 2)]
        public int TrainerId { get; set; }

        public virtual Course Course { get; set; }
        public virtual Trainer Trainer { get; set; }
    }
}
