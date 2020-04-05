using PrivateSchool.Entities.Concrete;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrivateSchool.Entities.Intermediaries
{
    public class StudentCourseAssignemnts 
    {
        [Key, Column(Order = 1)]
        public int StudentId { get; set; }

        [Key, Column(Order = 2)]
        public int TrainerId { get; set; }
        [Key, Column(Order = 3)]
        public int CourseId { get; set; }
        public double? Mark { get; set; }


        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
        public virtual Assignment Assignment { get; set; }

    }
}

