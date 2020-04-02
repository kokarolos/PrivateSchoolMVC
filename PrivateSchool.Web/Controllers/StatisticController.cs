using PrivateSchool.Entities.ViewModels;
using PrivateSchool.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrivateSchool.Web.Controllers
{
    public class StatisticController : Controller
    {
        private StudentRepository studentRepos = new StudentRepository();
        private TrainerRepository trainerRepos = new TrainerRepository();
        private CourseRepository courseRepos = new CourseRepository();
        private AssignmentRepository assignmentRepository = new AssignmentRepository();
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

            vm.CourseStats = courses.Where(x => x.Students != null && x.Trainers != null && x.Assignments != null );


            return View(vm);
        }
    }
}