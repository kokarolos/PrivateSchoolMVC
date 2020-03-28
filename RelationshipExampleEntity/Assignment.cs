using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace RelationshipExampleEntity
{
    public class Assignment
    {
        [ForeignKey("Course")]
        public int AssignmentId { get; set; }
        public string Title { get; set; }
        public virtual Course Course { get; set; }

    }
}
