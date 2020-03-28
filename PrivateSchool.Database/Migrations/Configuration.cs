namespace PrivateSchool.Database.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using PrivateSchool.Entities.Concrete;

    internal sealed class Configuration : DbMigrationsConfiguration<m_Database>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(m_Database context)
        {
            //------Conrete------

            var c1 = new Course() { Stream = "CB9", Type = Entities.Concrete.Type.C };
            var c2 = new Course() { Stream = "CB10", Type = Entities.Concrete.Type.CSharp };
            var c3 = new Course() { Stream = "CB11", Type = Entities.Concrete.Type.Java };
            var c4 = new Course() { Stream = "CB12", Type = Entities.Concrete.Type.JS };
            var c5 = new Course() { Stream = "CB13", Type = Entities.Concrete.Type.CSharp };

            var s1 = new Student() { FirstName = "Karol", LastName = "Koniewicz", DateOfBirth = new DateTime(1994, 10, 13), TuitionFees = 500 };
            var s2 = new Student() { FirstName = "Sofia", LastName = "Panta", DateOfBirth = new DateTime(1996, 10, 13), TuitionFees = 1455 };
            var s3 = new Student() { FirstName = "Tio", LastName = "Pantas", DateOfBirth = new DateTime(1999, 10, 13), TuitionFees = 124321 };
            var s4 = new Student() { FirstName = "Panos", LastName = "Rizos", DateOfBirth = new DateTime(1992, 10, 13), TuitionFees = 5001 };
            var s5 = new Student() { FirstName = "Giorgos", LastName = "Poulakos", DateOfBirth = new DateTime(1982, 11, 3), TuitionFees = 5201 };
            var s6 = new Student() { FirstName = "Thanos", LastName = "Katrakis", DateOfBirth = new DateTime(1991, 12, 30), TuitionFees = 2001 };
            var s7 = new Student() { FirstName = "Stathis", LastName = "Kanelis", DateOfBirth = new DateTime(1990, 1, 25), TuitionFees = 3001 };
            var s8 = new Student() { FirstName = "Zachos", LastName = "Kritikos", DateOfBirth = new DateTime(1982, 10, 13), TuitionFees = 100 };
            var s9 = new Student() { FirstName = "Xeno", LastName = "Xiliomidis", DateOfBirth = new DateTime(1972, 10, 13), TuitionFees = 1001 };
            var s10 = new Student() { FirstName = "Giorgos", LastName = "Tsakwnas", DateOfBirth = new DateTime(1912, 10, 13), TuitionFees = 2101 };
            var s11 = new Student() { FirstName = "Nikolay", LastName = "Pavlov", DateOfBirth = new DateTime(1993, 8, 7), TuitionFees = 1311 };

            var a1 = new Assignment() { Description = "PrivateSchoolAssignment" };
            var a2 = new Assignment() { Description = "DatabaseAssignment" };
            var a3 = new Assignment() { Description = "FrontEndAssignment" };
            var a4 = new Assignment() { Description = "BackEndAssignment" };

            var t1 = new Trainer() { FirstName = "Hector", LastName = "Gkatsos" };
            var t2 = new Trainer() { FirstName = "Billy", LastName = "Takis" };
            var t3 = new Trainer() { FirstName = "Makis", LastName = "Vader" };
            var t4 = new Trainer() { FirstName = "Mitsos", LastName = "Testoglou" };
            var t5 = new Trainer() { FirstName = "Trakis", LastName = "Pagkakis" };

            c1.Students = new List<Student>() { s1, s2, s3, s4, s5, s6 };
            c1.Assignments = new List<Assignment>() { a1, a2, a3 };
            c1.Trainers = new List<Trainer>() { t1, t2, t3 };

            c2.Students = new List<Student>() { s6, s7, s8, s9, s10, s11 };
            c2.Assignments = new List<Assignment>() { a2, a3, a4 };
            c2.Trainers = new List<Trainer>() { t1, t4, t5 };

            c3.Students = new List<Student>() { s1, s11, s2, s10, s3, s9 };
            c3.Assignments = new List<Assignment>() { a1, a4, a2 };
            c3.Trainers = new List<Trainer>() { t3, t1, t5 };

            c4.Students = new List<Student>() { s5, s9, s1, s3, s7, s8 };
            c4.Assignments = new List<Assignment>() { a2, a3, a4 };
            c4.Trainers = new List<Trainer>() { t2, t1, t5 };

            c5.Students = new List<Student>() { s1, s5, s7, s9, s11, s2 };
            c5.Assignments = new List<Assignment>() { a4, a1, a3 };
            c5.Trainers = new List<Trainer>() { t2, t3, t1 };

            context.Assignment.AddOrUpdate(x => x.Description, a1, a2, a3, a4);
            context.Trainer.AddOrUpdate(x => x.LastName, t1, t2, t3, t4, t5);
            context.Student.AddOrUpdate(x => x.LastName, s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11);
            context.Course.AddOrUpdate(x => x.Stream, c1, c2, c3, c4, c5);
            context.SaveChanges();
        }
    }
}
