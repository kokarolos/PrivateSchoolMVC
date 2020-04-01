namespace PrivateSchool.Database.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Validation;
    using PrivateSchool.Entities.Concrete;
    using PrivateSchool.Entities.Intermediaries;

    internal sealed class Configuration : DbMigrationsConfiguration<m_Database>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(m_Database context)
        {
            //------Conrete------

            var c1 = new Course() { Stream = "CB09", Type = Entities.Concrete.Type.C, StartingDate = new DateTime(2020, 5, 1), EndingDate = new DateTime(2020, 11, 1), PhotoUrl = "https://dummyimage.com/600x400/000/fff&text=CB9" };
            var c2 = new Course() { Stream = "CB10", Type = Entities.Concrete.Type.CSharp, StartingDate = new DateTime(2020, 6, 1), EndingDate = new DateTime(2020, 12, 1), PhotoUrl = "https://dummyimage.com/600x400/000/fff&text=CB10" };
            var c3 = new Course() { Stream = "CB11", Type = Entities.Concrete.Type.Java, StartingDate = new DateTime(2020, 7, 1), EndingDate = new DateTime(2021, 11, 3), PhotoUrl = "https://dummyimage.com/600x400/000/fff&text=CB11" };
            var c4 = new Course() { Stream = "CB12", Type = Entities.Concrete.Type.JS, StartingDate = new DateTime(2020, 8, 1), EndingDate = new DateTime(2021, 9, 5), PhotoUrl = "https://dummyimage.com/600x400/000/fff&text=CB12" };
            var c5 = new Course() { Stream = "CB13", Type = Entities.Concrete.Type.CSharp, StartingDate = new DateTime(2020, 9, 1), EndingDate = new DateTime(2021, 12, 12), PhotoUrl = "https://dummyimage.com/600x400/000/fff&text=CB13" };

            var s1 = new Student() { FirstName = "Karol", LastName = "Koniewicz", DateOfBirth = new DateTime(1994, 10, 13), TuitionFees = 500, Email = "karolos@gmail.com", PhoneNumber = "689102021", PhotoUrl = "https://ollienollie.files.wordpress.com/2009/10/untitled-161.jpg?w=700&h=" };
            var s2 = new Student() { FirstName = "Sofia", LastName = "Panta", DateOfBirth = new DateTime(1996, 10, 13), TuitionFees = 1455, Email = "sofia@gmail.com", PhoneNumber = "689102022", PhotoUrl = "https://ollienollie.files.wordpress.com/2009/10/untitled-151.jpg?w=700&h=" };
            var s3 = new Student() { FirstName = "Tio", LastName = "Pantas", DateOfBirth = new DateTime(1999, 10, 13), TuitionFees = 124321, Email = "tio@gmail.com", PhoneNumber = "6891020223", PhotoUrl = "https://ollienollie.files.wordpress.com/2009/10/untitled-141.jpg?w=700&h=" };
            var s4 = new Student() { FirstName = "Panos", LastName = "Rizos", DateOfBirth = new DateTime(1992, 10, 13), TuitionFees = 5001, Email = "panos@gmail.com", PhoneNumber = "689102024", PhotoUrl = "https://ollienollie.files.wordpress.com/2009/10/untitled-181.jpg?w=700&h=" };
            var s5 = new Student() { FirstName = "Giorgos", LastName = "Poulakos", DateOfBirth = new DateTime(1982, 11, 3), TuitionFees = 5201, Email = "ggiorgos@gmail.com", PhoneNumber = "689102025", PhotoUrl = "https://ollienollie.files.wordpress.com/2009/10/untitled-211.jpg?w=700&h=" };
            var s6 = new Student() { FirstName = "Thanos", LastName = "Katrakis", DateOfBirth = new DateTime(1991, 12, 30), TuitionFees = 2001, Email = "thanos@gmail.com", PhoneNumber = "689102026", PhotoUrl = "https://ollienollie.files.wordpress.com/2009/10/untitled-261.jpg?w=700&h=" };
            var s7 = new Student() { FirstName = "Stathis", LastName = "Kanelis", DateOfBirth = new DateTime(1990, 1, 25), TuitionFees = 3001, Email = "stathis@gmail.com", PhoneNumber = "689102027", PhotoUrl = "https://ollienollie.files.wordpress.com/2009/10/untitled-271.jpg?w=700&h=" };
            var s8 = new Student() { FirstName = "Zachos", LastName = "Kritikos", DateOfBirth = new DateTime(1982, 10, 13), TuitionFees = 100, Email = "zachos@gmail.com", PhoneNumber = "689102028", PhotoUrl = "https://ollienollie.files.wordpress.com/2009/10/untitled-281.jpg?w=700&h=" };
            var s9 = new Student() { FirstName = "Xeno", LastName = "Xiliomidis", DateOfBirth = new DateTime(1972, 10, 13), TuitionFees = 1001, Email = "xeno@gmail.com", PhoneNumber = "6891020221", PhotoUrl = "https://ollienollie.files.wordpress.com/2009/10/untitled-311.jpg?w=700&h=" };
            var s10 = new Student() { FirstName = "Giorgos", LastName = "Tsakwnas", DateOfBirth = new DateTime(1972, 10, 13), TuitionFees = 2101, Email = "thisistrap@gmail.com", PhoneNumber = "689102023", PhotoUrl = "https://ollienollie.files.wordpress.com/2009/10/untitled-321.jpg?w=700&h=" };
            var s11 = new Student() { FirstName = "Eleni", LastName = "Parisi", DateOfBirth = new DateTime(1997, 8, 7), TuitionFees = 5234, Email = "parisi@gmail.com", PhoneNumber = "689102024", PhotoUrl = "https://ollienollie.files.wordpress.com/2009/10/untitled-191.jpg?w=700&h=" };
            var s12 = new Student() { FirstName = "Ioanis", LastName = "Manthos", DateOfBirth = new DateTime(1998, 8, 7), TuitionFees = 234, Email = "manthos@gmail.com", PhoneNumber = "689102224", PhotoUrl = "https://ollienollie.files.wordpress.com/2009/10/untitled-331.jpg?w=700&h=" };
            var s13 = new Student() { FirstName = "Giannis", LastName = "Elefsiniotis", DateOfBirth = new DateTime(2001, 8, 11), TuitionFees = 3456, Email = "elef@gmail.com", PhoneNumber = "689102024", PhotoUrl = "https://ollienollie.files.wordpress.com/2009/10/untitled-351.jpg?w=700&h=" };
            var s14 = new Student() { FirstName = "Giannis", LastName = "Vlaxos", DateOfBirth = new DateTime(1999, 8, 7), TuitionFees = 4353, Email = "vlaxos@gmail.com", PhoneNumber = "689102124", PhotoUrl = "https://ollienollie.files.wordpress.com/2009/10/untitled-110.jpg?w=700&h=" };
            var s15 = new Student() { FirstName = "Paraskeuas", LastName = "Methana", DateOfBirth = new DateTime(1994, 5, 6), TuitionFees = 643, Email = "methana@gmail.com", PhoneNumber = "6891320284", PhotoUrl = "https://ollienollie.files.wordpress.com/2009/10/untitled-210.jpg?w=700&h=" };
            var s16 = new Student() { FirstName = "Kotsos", LastName = "Argiropoulos", DateOfBirth = new DateTime(1995, 2, 4), TuitionFees = 234, Email = "argiro@gmail.com", PhoneNumber = "689142027", PhotoUrl = "https://ollienollie.files.wordpress.com/2009/10/untitled-37.jpg?w=700&h=" };
            var s17 = new Student() { FirstName = "Vlassis", LastName = "Mouxos", DateOfBirth = new DateTime(1997, 1, 2), TuitionFees = 564, Email = "mouxos@gmail.com", PhoneNumber = "689122023", PhotoUrl = "https://ollienollie.files.wordpress.com/2009/10/untitled-41.jpg?w=700&h=" };
            var s18 = new Student() { FirstName = "Ilektra", LastName = "Spiliotaki", DateOfBirth = new DateTime(1991, 9, 17), TuitionFees = 1231, Email = "spiliotaki@gmail.com", PhoneNumber = "6891102026", PhotoUrl = "https://ollienollie.files.wordpress.com/2009/10/untitled-61.jpg?w=700&h=" };

            var a1 = new Assignment() { Description = "PrivateSchoolAssignment", SubDate = new DateTime(2020, 3, 3), PhotoUrl = "https://dummyimage.com/600x400/000/fff&text=AS1" };
            var a2 = new Assignment() { Description = "DatabaseAssignment", SubDate = new DateTime(2020, 5, 1), PhotoUrl = "https://dummyimage.com/600x400/000/fff&text=AS2" };
            var a3 = new Assignment() { Description = "FrontEndAssignment", SubDate = new DateTime(2020, 6, 11), PhotoUrl = "https://dummyimage.com/600x400/000/fff&text=AS3" };
            var a4 = new Assignment() { Description = "BackEndAssignment", SubDate = new DateTime(2020, 8, 22), PhotoUrl = "https://dummyimage.com/600x400/000/fff&text=AS4" };
            var a5 = new Assignment() { Description = "AspMvc", SubDate = new DateTime(2020, 7, 3), PhotoUrl = "https://dummyimage.com/600x400/000/fff&text=AS5" };
            var a6 = new Assignment() { Description = "Unity", SubDate = new DateTime(2020, 8, 1), PhotoUrl = "https://dummyimage.com/600x400/000/fff&text=AS6" };
            var a7 = new Assignment() { Description = "MicroControllers", SubDate = new DateTime(2020, 9, 11), PhotoUrl = "https://dummyimage.com/600x400/000/fff&text=AS7" };
            var a8 = new Assignment() { Description = "UnitTesting", SubDate = new DateTime(2020, 10, 22), PhotoUrl = "https://dummyimage.com/600x400/000/fff&text=AS8" };
            var a9 = new Assignment() { Description = "UnrealEnginge", SubDate = new DateTime(2020, 12, 3), PhotoUrl = "https://dummyimage.com/600x400/000/fff&text=AS9" };
            var a10 = new Assignment() { Description = "WinForms", SubDate = new DateTime(2020, 1, 1), PhotoUrl = "https://dummyimage.com/600x400/000/fff&text=AS10" };
            var a11 = new Assignment() { Description = "WPF", SubDate = new DateTime(2020, 7, 11), PhotoUrl = "https://dummyimage.com/600x400/000/fff&text=AS11" };
            var a12 = new Assignment() { Description = "Console Application", SubDate = new DateTime(2020, 8, 22), PhotoUrl = "https://dummyimage.com/600x400/000/fff&text=AS12" };

            var t1 = new Trainer() { FirstName = "Hector", LastName = "Gkatsos", Email = "hector@gmail.com", Salary = 9000, PhoneNumber = "691010101", PhotoUrl = "https://dummyimage.com/600x400/000/fff&text=HG" };
            var t2 = new Trainer() { FirstName = "Billy", LastName = "Takis", Email = "billy@gmail.com", Salary = 3000, PhoneNumber = "691010102", PhotoUrl = "https://dummyimage.com/600x400/000/fff&text=BT" };
            var t3 = new Trainer() { FirstName = "Makis", LastName = "Vader", Email = "makis@gmail.com", Salary = 2000, PhoneNumber = "691010103", PhotoUrl = "https://dummyimage.com/600x400/000/fff&text=MV" };
            var t4 = new Trainer() { FirstName = "Mitsos", LastName = "Testoglou", Email = "mitsos@gmail.com", Salary = 7000, PhoneNumber = "691010104", PhotoUrl = "https://dummyimage.com/600x400/000/fff&text=MT" };
            var t5 = new Trainer() { FirstName = "Trakis", LastName = "Pagkakis", Email = "trakis@gmail.com", Salary = 1005, PhoneNumber = "691010105", PhotoUrl = "https://dummyimage.com/600x400/000/fff&text=TP" };


            c1.Students = new List<Student>() { s1, s2, s3, s4, s5, s6 };
            c1.Assignments = new List<Assignment>() { a1, a2, a3 };
            c1.Trainers = new List<Trainer>() { t1, t2, t3 };

            var sa1 = new StudentAssignments() { Student = s1, Assignment = a1, StudentMark = 90, AssignmentMark = 100, SeedProp = "1" };
            var sa2 = new StudentAssignments() { Student = s1, Assignment = a2, StudentMark = 80, AssignmentMark = 100, SeedProp = "2" };
            var sa3 = new StudentAssignments() { Student = s1, Assignment = a3, StudentMark = 99, AssignmentMark = 100, SeedProp = "3" };
            var sa4 = new StudentAssignments() { Student = s2, Assignment = a1, StudentMark = 50, AssignmentMark = 100, SeedProp = "4" };
            var sa5 = new StudentAssignments() { Student = s2, Assignment = a2, StudentMark = 57, AssignmentMark = 100, SeedProp = "5" };
            var sa6 = new StudentAssignments() { Student = s2, Assignment = a3, StudentMark = 100, AssignmentMark = 100, SeedProp = "6" };
            var sa7 = new StudentAssignments() { Student = s3, Assignment = a1, StudentMark = 91, AssignmentMark = 100, SeedProp = "7" };
            var sa8 = new StudentAssignments() { Student = s3, Assignment = a2, StudentMark = 91, AssignmentMark = 100, SeedProp = "8" };
            var sa9 = new StudentAssignments() { Student = s3, Assignment = a3, StudentMark = 70, AssignmentMark = 100, SeedProp = "9" };
            var sa10 = new StudentAssignments() { Student = s4, Assignment = a1, StudentMark = 100, AssignmentMark = 100, SeedProp = "10" };
            var sa11 = new StudentAssignments() { Student = s4, Assignment = a2, StudentMark = 60, AssignmentMark = 100, SeedProp = "11" };
            var sa12 = new StudentAssignments() { Student = s4, Assignment = a3, StudentMark = 65, AssignmentMark = 100, SeedProp = "12" };
            var sa13 = new StudentAssignments() { Student = s5, Assignment = a1, StudentMark = 40, AssignmentMark = 100, SeedProp = "13" };
            var sa14 = new StudentAssignments() { Student = s5, Assignment = a2, StudentMark = 90, AssignmentMark = 100, SeedProp = "14" };
            var sa15 = new StudentAssignments() { Student = s5, Assignment = a3, StudentMark = 99, AssignmentMark = 100, SeedProp = "15" };
            var sa16 = new StudentAssignments() { Student = s6, Assignment = a1, StudentMark = 90, AssignmentMark = 100, SeedProp = "16" };
            var sa17 = new StudentAssignments() { Student = s6, Assignment = a2, StudentMark = 70, AssignmentMark = 100, SeedProp = "17" };
            var sa18 = new StudentAssignments() { Student = s6, Assignment = a3, StudentMark = 79, AssignmentMark = 100, SeedProp = "18" };

            c2.Students = new List<Student>() { s6, s7, s8, s9, s10, s11 };
            c2.Assignments = new List<Assignment>() { a4, a5, a6 };
            c2.Trainers = new List<Trainer>() { t1, t4, t5 };

            var sa19 = new StudentAssignments() { Student = s6, Assignment = a4, StudentMark = 79, AssignmentMark = 100, SeedProp = "19" };
            var sa20 = new StudentAssignments() { Student = s6, Assignment = a5, StudentMark = 91, AssignmentMark = 100, SeedProp = "20" };
            var sa21 = new StudentAssignments() { Student = s6, Assignment = a6, StudentMark = 100, AssignmentMark = 100, SeedProp = "21" };
            var sa22 = new StudentAssignments() { Student = s7, Assignment = a4, StudentMark = 100, AssignmentMark = 100, SeedProp = "22" };
            var sa23 = new StudentAssignments() { Student = s7, Assignment = a5, StudentMark = 100, AssignmentMark = 100, SeedProp = "23" };
            var sa24 = new StudentAssignments() { Student = s7, Assignment = a6, StudentMark = 100, AssignmentMark = 100, SeedProp = "24" };
            var sa25 = new StudentAssignments() { Student = s8, Assignment = a4, StudentMark = 91, AssignmentMark = 100, SeedProp = "25" };
            var sa26 = new StudentAssignments() { Student = s8, Assignment = a5, StudentMark = 91, AssignmentMark = 100, SeedProp = "26" };
            var sa27 = new StudentAssignments() { Student = s8, Assignment = a6, StudentMark = 72, AssignmentMark = 100, SeedProp = "27" };
            var sa28 = new StudentAssignments() { Student = s9, Assignment = a4, StudentMark = 100, AssignmentMark = 100, SeedProp = "28" };
            var sa29 = new StudentAssignments() { Student = s9, Assignment = a5, StudentMark = 69, AssignmentMark = 100, SeedProp = "29" };
            var sa30 = new StudentAssignments() { Student = s9, Assignment = a6, StudentMark = 85, AssignmentMark = 100, SeedProp = "30" };
            var sa31 = new StudentAssignments() { Student = s10, Assignment = a4, StudentMark = 30, AssignmentMark = 100, SeedProp = "31" };
            var sa32 = new StudentAssignments() { Student = s10, Assignment = a5, StudentMark = 76, AssignmentMark = 100, SeedProp = "32" };
            var sa33 = new StudentAssignments() { Student = s10, Assignment = a6, StudentMark = 45, AssignmentMark = 100, SeedProp = "33" };
            var sa34 = new StudentAssignments() { Student = s11, Assignment = a4, StudentMark = 90, AssignmentMark = 100, SeedProp = "34" };
            var sa35 = new StudentAssignments() { Student = s11, Assignment = a5, StudentMark = 70, AssignmentMark = 100, SeedProp = "35" };
            var sa36 = new StudentAssignments() { Student = s11, Assignment = a6, StudentMark = 79, AssignmentMark = 100, SeedProp = "36" };

            c3.Students = new List<Student>() { s1, s11, s2, s10, s3, s9 };
            c3.Assignments = new List<Assignment>() { a7, a8, a9 };
            c3.Trainers = new List<Trainer>() { t3, t1, t5 };

            var sa37 = new StudentAssignments() { Student = s1, Assignment = a7, StudentMark = 99, AssignmentMark = 100, SeedProp = "37" };
            var sa38 = new StudentAssignments() { Student = s1, Assignment = a8, StudentMark = 51, AssignmentMark = 100, SeedProp = "38" };
            var sa39 = new StudentAssignments() { Student = s1, Assignment = a9, StudentMark = 90, AssignmentMark = 100, SeedProp = "39" };
            var sa40 = new StudentAssignments() { Student = s11, Assignment = a7, StudentMark = 90, AssignmentMark = 100, SeedProp = "40" };
            var sa41 = new StudentAssignments() { Student = s11, Assignment = a8, StudentMark = 90, AssignmentMark = 100, SeedProp = "41" };
            var sa42 = new StudentAssignments() { Student = s11, Assignment = a9, StudentMark = 90, AssignmentMark = 100, SeedProp = "42" };
            var sa43 = new StudentAssignments() { Student = s2, Assignment = a7, StudentMark = 91, AssignmentMark = 100, SeedProp = "43" };
            var sa44 = new StudentAssignments() { Student = s2, Assignment = a8, StudentMark = 91, AssignmentMark = 100, SeedProp = "44" };
            var sa45 = new StudentAssignments() { Student = s2, Assignment = a9, StudentMark = 78, AssignmentMark = 100, SeedProp = "45" };
            var sa46 = new StudentAssignments() { Student = s10, Assignment = a7, StudentMark = 100, AssignmentMark = 100, SeedProp = "46" };
            var sa47 = new StudentAssignments() { Student = s10, Assignment = a8, StudentMark = 98, AssignmentMark = 100, SeedProp = "47" };
            var sa48 = new StudentAssignments() { Student = s10, Assignment = a9, StudentMark = 91, AssignmentMark = 100, SeedProp = "48" };
            var sa49 = new StudentAssignments() { Student = s3, Assignment = a7, StudentMark = 90, AssignmentMark = 100, SeedProp = "49" };
            var sa50 = new StudentAssignments() { Student = s3, Assignment = a8, StudentMark = 76, AssignmentMark = 100, SeedProp = "50" };
            var sa51 = new StudentAssignments() { Student = s3, Assignment = a9, StudentMark = 95, AssignmentMark = 100, SeedProp = "51" };
            var sa52 = new StudentAssignments() { Student = s9, Assignment = a7, StudentMark = 95, AssignmentMark = 100, SeedProp = "52" };
            var sa53 = new StudentAssignments() { Student = s9, Assignment = a8, StudentMark = 79, AssignmentMark = 100, SeedProp = "53" };
            var sa54 = new StudentAssignments() { Student = s9, Assignment = a9, StudentMark = 49, AssignmentMark = 100, SeedProp = "54" };

            c4.Students = new List<Student>() { s5, s9, s1, s2, s17, s18 };
            c4.Assignments = new List<Assignment>() { a10, a11, a12 };
            c4.Trainers = new List<Trainer>() { t2, t1, t5 };

            var sa55 = new StudentAssignments() { Student = s5, Assignment = a10, StudentMark = 86, AssignmentMark = 100, SeedProp = "55" };
            var sa56 = new StudentAssignments() { Student = s5, Assignment = a11, StudentMark = 46, AssignmentMark = 100, SeedProp = "56" };
            var sa57 = new StudentAssignments() { Student = s5, Assignment = a12, StudentMark = 96, AssignmentMark = 100, SeedProp = "57" };
            var sa58 = new StudentAssignments() { Student = s9, Assignment = a10, StudentMark = 96, AssignmentMark = 100, SeedProp = "58" };
            var sa59 = new StudentAssignments() { Student = s9, Assignment = a11, StudentMark = 96, AssignmentMark = 100, SeedProp = "59" };
            var sa60 = new StudentAssignments() { Student = s9, Assignment = a12, StudentMark = 96, AssignmentMark = 100, SeedProp = "60" };
            var sa61 = new StudentAssignments() { Student = s1, Assignment = a10, StudentMark = 96, AssignmentMark = 100, SeedProp = "61" };
            var sa62 = new StudentAssignments() { Student = s1, Assignment = a11, StudentMark = 66, AssignmentMark = 100, SeedProp = "62" };
            var sa63 = new StudentAssignments() { Student = s1, Assignment = a12, StudentMark = 76, AssignmentMark = 100, SeedProp = "63" };
            var sa64 = new StudentAssignments() { Student = s2, Assignment = a10, StudentMark = 100, AssignmentMark = 100, SeedProp = "64" };
            var sa65 = new StudentAssignments() { Student = s2, Assignment = a11, StudentMark = 98, AssignmentMark = 100, SeedProp = "65" };
            var sa66 = new StudentAssignments() { Student = s2, Assignment = a12, StudentMark = 91, AssignmentMark = 100, SeedProp = "66" };
            var sa67 = new StudentAssignments() { Student = s17, Assignment = a10, StudentMark = 90, AssignmentMark = 100, SeedProp = "67" };
            var sa68 = new StudentAssignments() { Student = s17, Assignment = a11, StudentMark = 76, AssignmentMark = 100, SeedProp = "68" };
            var sa69 = new StudentAssignments() { Student = s17, Assignment = a12, StudentMark = 95, AssignmentMark = 100, SeedProp = "69" };
            var sa70 = new StudentAssignments() { Student = s18, Assignment = a10, StudentMark = 95, AssignmentMark = 100, SeedProp = "70" };
            var sa71 = new StudentAssignments() { Student = s18, Assignment = a11, StudentMark = 79, AssignmentMark = 100, SeedProp = "71" };
            var sa72 = new StudentAssignments() { Student = s18, Assignment = a12, StudentMark = 100, AssignmentMark = 100, SeedProp = "72" };

            c5.Students = new List<Student>() { s11, s12, s13, s14, s15, s16 };
            c5.Assignments = new List<Assignment>() { a12, a1, a3 };
            c5.Trainers = new List<Trainer>() { t2, t3, t1 };

            var sa73 = new StudentAssignments() { Student = s11, Assignment = a12, StudentMark = 66, AssignmentMark = 100, SeedProp = "73" };
            var sa74 = new StudentAssignments() { Student = s11, Assignment = a1, StudentMark = 96, AssignmentMark = 100, SeedProp = "74" };
            var sa75 = new StudentAssignments() { Student = s11, Assignment = a3, StudentMark = 100, AssignmentMark = 100, SeedProp = "75" };
            var sa76 = new StudentAssignments() { Student = s12, Assignment = a12, StudentMark = 59, AssignmentMark = 100, SeedProp = "76" };
            var sa77 = new StudentAssignments() { Student = s12, Assignment = a1, StudentMark = 77, AssignmentMark = 100, SeedProp = "77" };
            var sa78 = new StudentAssignments() { Student = s12, Assignment = a3, StudentMark = 88, AssignmentMark = 100, SeedProp = "78" };
            var sa79 = new StudentAssignments() { Student = s13, Assignment = a12, StudentMark = 87, AssignmentMark = 100, SeedProp = "79" };
            var sa80 = new StudentAssignments() { Student = s13, Assignment = a1, StudentMark = 97, AssignmentMark = 100, SeedProp = "80" };
            var sa81 = new StudentAssignments() { Student = s13, Assignment = a3, StudentMark = 91, AssignmentMark = 100, SeedProp = "81" };
            var sa82 = new StudentAssignments() { Student = s14, Assignment = a12, StudentMark = 100, AssignmentMark = 100, SeedProp = "82" };
            var sa83 = new StudentAssignments() { Student = s14, Assignment = a1, StudentMark = 69, AssignmentMark = 100, SeedProp = "83" };
            var sa84 = new StudentAssignments() { Student = s14, Assignment = a3, StudentMark = 83, AssignmentMark = 100, SeedProp = "84" };
            var sa85 = new StudentAssignments() { Student = s15, Assignment = a12, StudentMark = 83, AssignmentMark = 100, SeedProp = "85" };
            var sa86 = new StudentAssignments() { Student = s15, Assignment = a1, StudentMark = 100, AssignmentMark = 100, SeedProp = "86" };
            var sa87 = new StudentAssignments() { Student = s15, Assignment = a3, StudentMark = 78, AssignmentMark = 100, SeedProp = "87" };
            var sa88 = new StudentAssignments() { Student = s16, Assignment = a4, StudentMark = 64, AssignmentMark = 100, SeedProp = "88" };
            var sa89 = new StudentAssignments() { Student = s16, Assignment = a1, StudentMark = 83, AssignmentMark = 100, SeedProp = "89" };
            var sa90 = new StudentAssignments() { Student = s16, Assignment = a3, StudentMark = 100, AssignmentMark = 100, SeedProp = "90" };

            try
            {
                context.Assignments.AddOrUpdate(x => x.Description, a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12);
                context.Trainers.AddOrUpdate(x => x.Email, t1, t2, t3, t4, t5);
                context.Students.AddOrUpdate(x => x.Email, s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15, s16, s17, s18);
                context.Courses.AddOrUpdate(x => x.Stream, c1, c2, c3, c4, c5);
                context.StudentAssignments.AddOrUpdate(x => x.SeedProp,
                  sa1, sa2, sa3, sa4, sa5, sa6, sa7, sa8, sa9,
                  sa10, sa11, sa12, sa13, sa14, sa15, sa16, sa17, sa18, sa19,
                  sa20, sa21, sa22, sa23, sa24, sa25, sa26, sa27, sa28, sa29,
                  sa30, sa31, sa32, sa33, sa34, sa35, sa36, sa37, sa38, sa39,
                  sa40, sa41, sa42, sa43, sa44, sa45, sa46, sa47, sa48, sa49,
                  sa50, sa51, sa52, sa53, sa54, sa55, sa56, sa57, sa58, sa59,
                  sa60, sa61, sa62, sa63, sa64, sa65, sa66, sa67, sa68, sa69,
                  sa70, sa71, sa72, sa73, sa74, sa75, sa76, sa77, sa78, sa79,
                  sa80, sa81, sa82, sa83, sa84, sa85, sa86, sa87, sa88, sa89,
                  sa90);
                context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }
    }
}


