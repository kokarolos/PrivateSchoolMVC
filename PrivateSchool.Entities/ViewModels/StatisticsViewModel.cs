using PrivateSchool.Entities.Concrete;
using System.Collections.Generic;


namespace PrivateSchool.Entities.ViewModels
{
    public class StatisticsViewModel
    {
        public int StudentsCount { get; set; }
        public int AssignmentsCount { get; set; }
        public int TrainersCount { get; set; }
        public int CoursesCount { get; set; }
        public int MyProperty { get; set; }
        public IEnumerable<Course> CourseStats { get; set; }
        public Dictionary<string, double> StudentsByAssignments { get; set; }
        public Dictionary<string,double> MarksPerCourse { get; set; }
        public Dictionary<string,double> MarksPerCoursePerAssignment { get; set; }
    }
}
