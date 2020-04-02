using System;
using PrivateSchool.Services;
using Type = PrivateSchool.Entities.Concrete.Type;

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
            StudentAssignemnts sa = new StudentAssignemnts();

            var courses = cs.GetCourses();
            var studentsA = sa.GetStudentAssignemnts();
            var assi = ass.GetAssignments();
            foreach (var item in assi)
            {
                Console.WriteLine(item.Description);
                foreach (var obj in studentsA)
                {
                    if(item.AssignmentId.Equals(obj.AssignmentId))
                    {
                        Console.WriteLine(obj.AssignmentMark);
                    }
                }
            }

      


        //    var trainers = ts.GetTrainers();
        //    var assignments = ass.GetAssignments();
        //    var students = ss.GetStudents();
            //foreach (var student in students)
            //{
            //    Console.WriteLine(student.FirstName);
            //    foreach (var course in student.Courses)
            //    {
            //        Console.Write("\tc:{0} ",course.Stream);
            //        foreach (var assignemnt in course.Assignments)
            //        {
            //            Console.Write("\ta:{0} ",assignemnt.Description);
            //        }
            //    }
            //    Console.WriteLine();
            //}


            //var types = Enum.GetNames(typeof(Type));
            //foreach (var item in types)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in courses)
            //{
            //    Console.WriteLine(item.Type.ToString());
            //}
        }
    }
}
