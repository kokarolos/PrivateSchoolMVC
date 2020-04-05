//using PrivateSchool.Services;
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace PrivateSchool.Desktop
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            CourseRepository cs = new CourseRepository();
//            StudentRepository ss = new StudentRepository();
//            AssignmentRepository ass = new AssignmentRepository();
//            TrainerRepository ts = new TrainerRepository();
//            StudentAssignmentRepository sa = new StudentAssignmentRepository();

//            //var courses = cs.GetCourses();
//            //var assignments = ass.GetAssignments();
//            //var count = 0;
//            //var avg = 0;
//            //AVG Per Assignment
//            //foreach (var assignment in assignments)
//            //{
//            //    Console.Write(assignment.Description);
//            //    foreach (var item in studentsA)
//            //    {
//            //        if (item.Assignment.Description.Equals(assignment.Description))
//            //        {
//            //            avg += item.StudentMark;
//            //            count++;
//            //        }
//            //    }
//            //    Console.WriteLine(avg / count);
//            //}

//            //var trainers = ts.GetTrainers();
//            //var assignments = ass.GetAssignments();
//            //var students = ss.GetStudents();
//            //foreach (var student in students)
//            //{
//            //    Console.WriteLine(student.FirstName);
//            //    foreach (var course in student.Courses)
//            //    {
//            //        Console.Write("\tc:{0} ", course.Stream);
//            //        foreach (var assignemnt in course.Assignments)
//            //        {
//            //            Console.Write("\ta:{0} ", assignemnt.Description);
//            //        }
//            //    }
//            //    Console.WriteLine();
//            //}


//            //var types = Enum.GetNames(typeof(Type));
//            //foreach (var item in types)
//            //{
//            //    Console.WriteLine(item);
//            //}

//            //foreach (var item in courses)
//            //{
//            //    Console.WriteLine(item.Type.ToString());
//            //}


//            //List<int> p = new List<int>() { 22, 23, 25, 22, 25, 22, 25, 23, 25, 25, 25, 22, 22, 22, 22 };
//            //var e = p.GroupBy(x => x).Select(x => new { num = x.Key, count = x.Count(), average = x.Average() }).AsEnumerable();


//            //var studentsAssi = sa.GetStudentAssignments();
//            //var students = ss.GetStudents();



//            //var w = studentsAssi.GroupBy(x => x.Assignment).Select(g => new { Desc = g.Key.Description, AverageMark = g.Average(x => x.StudentMark) });

//            //Dictionary<string, double> keyValues = new Dictionary<string, double>();
//            //Dictionary<string, double> kati = new Dictionary<string, double>();

//            //List<Helper> helper = new List<Helper>();
//            //int counter = 0;
//            //double average = 0;
//            //foreach (var course in courses)
//            //{
//            //    foreach (var s in studentsAssi)
//            //    {
//            //        foreach (var item in course.Assignments)
//            //        {
//            //            if (item.AssignmentId.Equals(s.AssignmentId))
//            //            {
//            //                average += s.StudentMark;
//            //                counter++;
//            //            }
//            //        }
//            //    }
//            //    kati.Add(course.Stream, average / counter);
//            //    counter = 0;
//            //    average = 0;
//            //}
//            //Dictionary<string, double> Nested = new Dictionary<string, double>();
//            //Dictionary<string, double> Nested2 = new Dictionary<string, double>();




//            //foreach (var item in Composite)
//            //{
//            //    Console.WriteLine($"{item.Key} {item.Value}");
//            //}
//            int counter = 0;
//            double average = 0;
//            double mark=0;
//            Dictionary<string, double> keyValuePairs = new Dictionary<string, double>();
//            Dictionary<string, double> GetOutePouKserw = new Dictionary<string, double>();

//            foreach ( var course in cs.GetCourses())
//            {
//                foreach (var assignment in course.Assignments)
//                {
//                    foreach (var item in sa.GetStudentAssignments())
//                    {
//                        if(item.AssignmentId.Equals(assignment.AssignmentId))
//                        {
//                            average += item.StudentMark;
//                            counter++;
//                        }
//                    }
//                    // Console.WriteLine($"{course.Stream} {assignment.Description} {average/counter}");
//                    mark = average / counter;
//                    keyValuePairs.Add(course.Stream + assignment.Description, mark);
//                }
//                average = 0;
//                counter = 0;
//            }
//            for(int i = 1; i <= keyValuePairs.Count()-1; i++)
//            {
//                var previousItem = keyValuePairs.ElementAt(i - 1);
//                var item = keyValuePairs.ElementAt(i);
//                var itemStr = item.Key.Replace(" ", string.Empty);
//                var previousStr = previousItem.Key.Replace(" ", string.Empty);
//                if (itemStr == previousStr)
//                {
//                    Console.WriteLine(itemStr);
//                }
//            }


//        }

//        public static Dictionary<string, double> Get()
//        {
//            CourseRepository cs = new CourseRepository();
//            StudentRepository ss = new StudentRepository();
//            AssignmentRepository ass = new AssignmentRepository();
//            TrainerRepository ts = new TrainerRepository();
//            StudentAssignmentRepository sa = new StudentAssignmentRepository();
//            Dictionary<string, double> Composite = new Dictionary<string, double>();
//            string AssignemntDesc = "";
//            double average = 0;
//            int counter = 0;
//            var courses = cs.GetCourses();
//            foreach (var course in courses )
//            {
//                foreach (var assigment in course.Assignments)
//                {
//                    foreach (var item in sa.GetStudentAssignments())
//                    {
//                        if (assigment.AssignmentId.Equals(item.AssignmentId))
//                        {
//                            AssignemntDesc = assigment.Description;
//                            average += item.StudentMark;
//                            counter++;
//                        }
//                    }

//                    var e = average / counter;
//                    Composite.Add(string.Format("{0} {1}", course.Stream, AssignemntDesc), e);
//                    AssignemntDesc = "";
//                    counter = 0;
//                    average = 0;
//                }

//            }
//            return Composite;
//        }
//        //public class Helper
//        //{
//        //    public string Desc { get; set; }
//        //    public string Stream { get; set; }
//        //    public double Average { get; set; }
//        //}
//    }
//}

