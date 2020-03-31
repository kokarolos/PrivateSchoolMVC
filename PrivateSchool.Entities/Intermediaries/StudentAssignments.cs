using PrivateSchool.Entities.Concrete;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrivateSchool.Entities.Intermediaries
{
    public class StudentAssignments
    {

        [Key, Column(Order = 1)]
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }

        [Key, Column(Order = 2)]
        public int AssignmentId { get; set; }
        public virtual Assignment Assignment { get; set; }

        [Range(0,101,ErrorMessage ="Mark must be between 0-100")]
        public int StudentMark { get; set; }
        [Range(0, 101, ErrorMessage = "Mark must be between 0-100")]
        
        public string SeedProp { get; set; }
        public int AssignmentMark { get; set; }

    }
}
