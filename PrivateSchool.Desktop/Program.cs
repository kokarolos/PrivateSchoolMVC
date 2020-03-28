using PrivateSchool.Database;
using PrivateSchool.Entities.Concrete;
using PrivateSchool.Entities.Intermediaries;
using PrivateSchool.Services;
using System;

namespace PrivateSchool.Desktop
{
    class Program
    {
        static void Main(string[] args)
        {
            CourseRepository cs = new CourseRepository();
            var courses = cs.GetCourses();
            foreach (var course in courses)
            {

                Console.WriteLine(course.Stream);
            }
        }
    }
}
