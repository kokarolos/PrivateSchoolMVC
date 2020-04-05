using PrivateSchool.Entities.ViewModels;
using PrivateSchool.Services;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace PrivateSchool.Web.Controllers
{
    public class StatisticController : Controller
    {
        private StudentRepository studentRepos = new StudentRepository();
        private TrainerRepository trainerRepos = new TrainerRepository();
        private CourseRepository courseRepos = new CourseRepository();
        private AssignmentRepository assignmentRepository = new AssignmentRepository();
        private StudentAssignmentRepository studentAssignemntsrepos = new StudentAssignmentRepository();
        // GET: Statistic
        public ActionResult Index()
        {
            var vm = new StatisticsViewModel();
            vm.StudentsCount = studentRepos.GetStudents().Count();
            vm.TrainersCount = trainerRepos.GetTrainers().Count();
            vm.CoursesCount = courseRepos.GetCourses().Count();
            vm.AssignmentsCount = assignmentRepository.GetAssignments().Count();

            var courses = courseRepos.GetCourses();
            var students = studentRepos.GetStudents();
            var trainers = trainerRepos.GetTrainers();
            var assigmnets = assignmentRepository.GetAssignments();
            var studentsAssigments = studentAssignemntsrepos.GetStudentAssignments();
            vm.CourseStats = courses.Where(x => x.Students != null && x.Trainers != null && x.Assignments != null);

            vm.StudentsByAssignments = GetStudentAssignements();
            vm.MarksPerCourse = GetMarksPerCourse();
            vm.MarksPerCoursePerAssignment = GetMarksPerCoursePerAssignment();

            return View(vm);
        }

        [NonAction]
        private Dictionary<string,double> GetMarksPerCourse()
        {
            Dictionary<string, double> marksPerCouse = new Dictionary<string, double>();
            var courses = courseRepos.GetCourses();
            var studentsAssignemnts = studentAssignemntsrepos.GetStudentAssignments();
            int counter = 0;
            double average = 0;
            foreach (var course in courses)
            {
                foreach (var s in studentsAssignemnts)
                {
                    foreach (var item in course.Assignments)
                    {
                        if (item.AssignmentId.Equals(s.AssignmentId))
                        {
                            average += s.StudentMark ;
                            counter++;
                        }
                    }
                }
                marksPerCouse.Add(course.Stream, average / counter);
                counter = 0;
                average = 0;
            }
            return marksPerCouse;
        }

        [NonAction]
        private Dictionary<string,double> GetMarksPerCoursePerAssignment()
        {
            Dictionary<string, double> Composite = new Dictionary<string, double>();
            var courses = courseRepos.GetCourses();
            var studentsAssignemnts = studentAssignemntsrepos.GetStudentAssignments();
            double average = 0;
            int counter = 0;
            string AssignemntDesc = "";

            foreach (var course in courses)
            {
                foreach (var assigment in course.Assignments)
                {
                    foreach (var item in studentsAssignemnts)
                    {
                        if (assigment.AssignmentId.Equals(item.AssignmentId))
                        {
                            AssignemntDesc = assigment.Description;
                            average += item.StudentMark;
                            counter++;
                        }
                    }
                    double mark = average / counter;
                    Composite.Add(string.Format("{0} {1}", course.Stream, AssignemntDesc), mark);
                    AssignemntDesc = "";
                }
                counter = 0;
                average = 0;
            }
            return Composite;
        }
        [NonAction]
        private Dictionary<string,double> GetStudentAssignements()
        {
            //anonymous => Key,->avg
            var query = studentAssignemntsrepos.GetStudentAssignments().GroupBy(x => x.Assignment)
                .Select(g =>
                new
                {
                    Desc = g.Key.Description,
                    AverageMark = g.Average(x => x.StudentMark)
                });
            Dictionary<string, double> AssignmentsStudentMarks = new Dictionary<string, double>(); //-> Like Casting to Eponymous Object

            foreach (var item in query) //populate dictionary and sending to vm
            {
                AssignmentsStudentMarks.Add(item.Desc, item.AverageMark);
            }

            return AssignmentsStudentMarks;
        }
    }
}