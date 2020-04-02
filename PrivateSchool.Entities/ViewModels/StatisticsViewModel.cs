using PrivateSchool.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public double AverageMarkStudentPerCourse { get; set; }
        public double AverageMarkStudentPerAssignement { get; set; }
        public double AverageMarkStudentPerAssignementPerCourse { get; set; }

    }
}
