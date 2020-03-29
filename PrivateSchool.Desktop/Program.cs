using System;
using PrivateSchool.Services;

namespace PrivateSchool.Desktop
{
    class Program
    {
        static void Main(string[] args)
        {
            CourseRepository cs = new CourseRepository();
            StudentRepository ss = new StudentRepository();
            AssignmentRepository ass = new AssignmentRepository();
            TrainerRepository ts = new TrainerRepository();


            var courses = cs.GetCourses();
            var trainers = ts.GetTrainers();
            var assignments = ass.GetAssignments();
            var students = ss.GetStudents();
            foreach (var course in courses)
            {
                Console.WriteLine(course.Stream);
            }
            foreach (var trainer in trainers)
            {
                Console.WriteLine(trainer.FirstName);
            }
            foreach (var student in students)
            {
                Console.WriteLine(student.FirstName);
            }
            foreach (var assignment in assignments)
            {
                Console.WriteLine(assignment.Description);
            }
        }
    }
}
