using System;
using System.Collections.Generic;
using System.Linq;
using PrivateSchool.Entities.Intermediaries;
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
            StudentAssignmentRepository sa = new StudentAssignmentRepository();

            //var courses = cs.GetCourses();
            //var studentsA = sa.GetStudentAssignemnts();
            //var assignments = ass.GetAssignments();
            //var count = 0;
            //var avg = 0;
            ////AVG Per Assignment
            //foreach (var assignment in assignments)
            //{
            //    Console.Write(assignment.Description);
            //    foreach (var item in studentsA)
            //    {
            //        if(item.Assignment.Description.Equals(assignment.Description))
            //        {
            //            avg+=item.StudentMark;
            //            count++;
            //        }
            //    }
            //    Console.WriteLine(avg/count);
            //}


            List<int> p = new List<int>() { 22, 23, 25, 22, 25, 22, 25, 23, 25, 25, 25, 22, 22, 22, 22 };
            var e = p.GroupBy(x => x).Select(x => new { num = x.Key, count = x.Count(), average = x.Average() }).AsEnumerable();

            var w = sa.GetStudentAssignemnts().GroupBy(x => x.Assignment).Select(group => new { a = group.Key, sa = group.Key.StudentAssignments.ToList() });
            foreach (var item in w)
            {
                Console.Write(item.a.Description);
                foreach (var obj in item.sa)
                {
                    Console.Write("\t"+obj.StudentMark);
                }
                Console.WriteLine();
            }


            //foreach (var item in e)
            //{
            //    Console.WriteLine(item);

            //}

            //var sas = sa.GetStudentAssignemnts().

            //foreach (var item in e)
            //{
              
            //}



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
