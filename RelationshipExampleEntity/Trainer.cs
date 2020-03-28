using System.ComponentModel.DataAnnotations.Schema;

namespace RelationshipExampleEntity
{
    public class Trainer
    {
        [ForeignKey("Course")]
        public int? CourseId { get; set; }
        public int TrainerId { get; set; }
        public string FirstName { get; set; }
        public virtual Course Course { get; set; }
    }
}
