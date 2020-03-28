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

            var c1 = new Course() { Stream = "CB9", Type = Entities.Concrete.Type.C ,StartingDate=new DateTime(2020,5,1),EndingDate= new DateTime(2020,11, 1) };
            var c2 = new Course() { Stream = "CB10", Type = Entities.Concrete.Type.CSharp, StartingDate = new DateTime(2020, 6, 1), EndingDate = new DateTime(2020, 12, 1) };
            var c3 = new Course() { Stream = "CB11", Type = Entities.Concrete.Type.Java, StartingDate = new DateTime(2020, 7, 1), EndingDate = new DateTime(2021, 11, 3) };
            var c4 = new Course() { Stream = "CB12", Type = Entities.Concrete.Type.JS, StartingDate = new DateTime(2020, 8, 1), EndingDate = new DateTime(2021, 9, 5) };
            var c5 = new Course() { Stream = "CB13", Type = Entities.Concrete.Type.CSharp, StartingDate = new DateTime(2020, 9, 1), EndingDate = new DateTime(2021, 12, 12) };

            var s1 = new Student() { FirstName = "Karol", LastName = "Koniewicz", DateOfBirth = new DateTime(1994, 10, 13), TuitionFees = 500,Email="karolos@gmail.com",PhoneNumber="689102021",PhotoUrl="#"};
            var s2 = new Student() { FirstName = "Sofia", LastName = "Panta", DateOfBirth = new DateTime(1996, 10, 13), TuitionFees = 1455, Email = "sofia@gmail.com", PhoneNumber = "689102022", PhotoUrl = "#" };
            var s3 = new Student() { FirstName = "Tio", LastName = "Pantas", DateOfBirth = new DateTime(1999, 10, 13), TuitionFees = 124321, Email = "tio@gmail.com", PhoneNumber = "6891020223", PhotoUrl = "#" };
            var s4 = new Student() { FirstName = "Panos", LastName = "Rizos", DateOfBirth = new DateTime(1992, 10, 13), TuitionFees = 5001, Email = "panos@gmail.com", PhoneNumber = "689102024", PhotoUrl = "#" };
            var s5 = new Student() { FirstName = "Giorgos", LastName = "Poulakos", DateOfBirth = new DateTime(1982, 11, 3), TuitionFees = 5201, Email = "ggiorgos@gmail.com", PhoneNumber = "689102025", PhotoUrl = "#" };
            var s6 = new Student() { FirstName = "Thanos", LastName = "Katrakis", DateOfBirth = new DateTime(1991, 12, 30), TuitionFees = 2001, Email = "thanos@gmail.com", PhoneNumber = "689102026", PhotoUrl = "#" };
            var s7 = new Student() { FirstName = "Stathis", LastName = "Kanelis", DateOfBirth = new DateTime(1990, 1, 25), TuitionFees = 3001, Email = "stathis@gmail.com", PhoneNumber = "689102027", PhotoUrl = "#" };
            var s8 = new Student() { FirstName = "Zachos", LastName = "Kritikos", DateOfBirth = new DateTime(1982, 10, 13), TuitionFees = 100, Email = "zachos@gmail.com", PhoneNumber = "689102028", PhotoUrl = "#" };
            var s9 = new Student() { FirstName = "Xeno", LastName = "Xiliomidis", DateOfBirth = new DateTime(1972, 10, 13), TuitionFees = 1001, Email = "xeno@gmail.com", PhoneNumber = "6891020221", PhotoUrl = "#" };
            var s10 = new Student() { FirstName = "Giorgos", LastName = "Tsakwnas", DateOfBirth = new DateTime(1972, 10, 13), TuitionFees = 2101, Email = "thisistrap@gmail.com", PhoneNumber = "689102023", PhotoUrl = "#" };
            var s11 = new Student() { FirstName = "Eleni", LastName = "Parisi", DateOfBirth = new DateTime(1997, 8, 7), TuitionFees = 5234, Email = "parisi@gmail.com", PhoneNumber = "689102024", PhotoUrl = "#" };
            var s12 = new Student() { FirstName = "Ioanis", LastName = "Manthos", DateOfBirth = new DateTime(1998, 8, 7), TuitionFees = 234, Email = "manthos@gmail.com", PhoneNumber = "689102224", PhotoUrl = "#" };
            var s13 = new Student() { FirstName = "Giannis", LastName = "Elefsiniotis", DateOfBirth = new DateTime(2001, 8, 11), TuitionFees = 3456, Email = "elef@gmail.com", PhoneNumber = "689102024", PhotoUrl = "#" };
            var s14 = new Student() { FirstName = "Giannis", LastName = "Vlaxos", DateOfBirth = new DateTime(1999, 8, 7), TuitionFees = 4353, Email = "vlaxos@gmail.com", PhoneNumber = "689102124", PhotoUrl = "#" };
            var s15 = new Student() { FirstName = "Paraskeuas", LastName = "Methana", DateOfBirth = new DateTime(1994, 5, 6), TuitionFees = 643, Email = "methana@gmail.com", PhoneNumber = "6891320284", PhotoUrl = "#" };
            var s16 = new Student() { FirstName = "Kotsos", LastName = "Argiropoulos", DateOfBirth = new DateTime(1995, 2, 4), TuitionFees = 234, Email = "argiro@gmail.com", PhoneNumber = "689142027", PhotoUrl = "#" };
            var s17 = new Student() { FirstName = "Vlassis", LastName = "Mouxos", DateOfBirth = new DateTime(1997, 1, 2), TuitionFees = 564, Email = "mouxos@gmail.com", PhoneNumber = "689122023", PhotoUrl = "#" };
            var s18 = new Student() { FirstName = "Ilektra", LastName = "Spiliotaki", DateOfBirth = new DateTime(1991, 9, 17), TuitionFees = 1231, Email = "spiliotaki@gmail.com", PhoneNumber = "6891102026", PhotoUrl = "#" };

            var a1 = new Assignment() { Description = "PrivateSchoolAssignment" ,SubDate= new DateTime(2020, 3, 3)};
            var a2 = new Assignment() { Description = "DatabaseAssignment" ,SubDate = new DateTime(2020, 5, 1) };
            var a3 = new Assignment() { Description = "FrontEndAssignment" ,SubDate = new DateTime(2020, 6, 11) };
            var a4 = new Assignment() { Description = "BackEndAssignment" ,SubDate = new DateTime(2020, 8, 22) };

            var t1 = new Trainer() { FirstName = "Hector", LastName = "Gkatsos",Email="hector@gmail.com",Salary=9000,PhoneNumber="691010101",PhotoUrl="#"};
            var t2 = new Trainer() { FirstName = "Billy", LastName = "Takis" ,Email = "billy@gmail.com", Salary = 3000, PhoneNumber = "691010102", PhotoUrl = "#" };
            var t3 = new Trainer() { FirstName = "Makis", LastName = "Vader" , Email = "makis@gmail.com", Salary = 2000, PhoneNumber = "691010103", PhotoUrl = "#" };
            var t4 = new Trainer() { FirstName = "Mitsos", LastName = "Testoglou", Email = "mitsos@gmail.com", Salary = 7000, PhoneNumber = "691010104", PhotoUrl = "#" };
            var t5 = new Trainer() { FirstName = "Trakis", LastName = "Pagkakis", Email = "trakis@gmail.com", Salary = 1000, PhoneNumber = "691010105", PhotoUrl = "#" };

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
            context.Trainer.AddOrUpdate(x => x.Email, t1, t2, t3, t4, t5);
            context.Student.AddOrUpdate(x => x.Email, s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11);
            context.Course.AddOrUpdate(x => x.Stream, c1, c2, c3, c4, c5);
            context.SaveChanges();
        }
    }
}
