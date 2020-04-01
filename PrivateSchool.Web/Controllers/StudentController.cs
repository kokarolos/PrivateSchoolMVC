using System.Linq;
using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;
using PrivateSchool.Entities.Concrete;
using PrivateSchool.Services;
using PagedList;
using PagedList.Mvc;

namespace PrivateSchool.Web.Controllers
{
    public class StudentController : Controller
    {
        private StudentRepository repos = new StudentRepository();

        // GET: Student
        public ActionResult Index(string sortOrder,string firstName,string lastName,int? minAge,int? maxAge,int? page)
        {
            var students = repos.GetStudents();

            ViewBag.CurrentFirstName = firstName;
            ViewBag.CurrentLastName = lastName;
            ViewBag.CurrentMinAge = minAge;
            ViewBag.CurrentMaxAge = maxAge;
            ViewBag.CurrentSortOrder = sortOrder;

            ViewBag.FirstNameSortParam = string.IsNullOrEmpty(sortOrder) ? "FirstNameDesc" : "";
            ViewBag.LastNameSortParam = sortOrder == "LastNameAsc" ? "LastNameDesc" : "LastNameAsc";
            ViewBag.AgeSortParam = sortOrder == "AgeAsc" ? "AgeDesc" : "AgeAsc";

            ViewBag.FNView = "badge badge-primary";
            ViewBag.LNView = "badge badge-primary";
            ViewBag.AGView = "badge badge-primary";

            switch (sortOrder)
            {
                case "FirstNameDesc":
                    students = students.OrderByDescending(x => x.FirstName);
                    ViewBag.FNView = "badge badge-danger"; 
                    break;
                case "LastNameAsc": 
                    students = students.OrderBy(x => x.LastName); 
                    ViewBag.LNView = "badge badge-success"; 
                    break;
                case "LastNameDesc":
                    students = students.OrderByDescending(x => x.LastName); 
                    ViewBag.LNView = "badge badge-danger"; 
                    break;
                case "AgeAsc": 
                    students = students.OrderBy(x => x.Age); 
                    ViewBag.AGView = "badge badge-success"; 
                    break;
                case "AgeDesc": 
                    students = students.OrderByDescending(x => x.Age);
                    ViewBag.AGView = "badge badge-danger"; 
                    break;

                default: students = students.OrderBy(x => x.FirstName); ViewBag.FNView = "badge badge-success"; break;
            }
            //FirstName Filter
            students = string.IsNullOrWhiteSpace(firstName) ? students : students.Where(x => x.FirstName.ToUpper().Contains(firstName.ToUpper()));
            //LastName Fillter
            students = string.IsNullOrWhiteSpace(lastName) ? students : students.Where(x => x.LastName.ToUpper().Contains(lastName.ToUpper()));
            //MinAge Filter
            students = minAge is null ? students : students.Where(x => x.Age >= minAge);
            //MaxAge Filter
            students = maxAge is null ? students : students.Where(x => x.Age <= maxAge);

            //Pagination
            var pageSize = 3;
            var pageNum = page ?? 1;

            return View(students.ToPagedList(pageNum, pageSize));
        }

        // GET: Student/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = repos.GetStudent(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StdudentId,FirstName,LastName,DateOfBirth,TuitionFees,PhoneNumber,Email,PhotoUrl")] Student student)
        {
            if (ModelState.IsValid)
            {
                repos.Insert(student);
                return RedirectToAction("Index");
            }

            return View(student);
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = repos.GetStudent(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: Student/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StudentId,FirstName,LastName,DateOfBirth,PhoneNumber,TuitionFees,Email,PhotoUrl")] Student student)
        {
            if (ModelState.IsValid)
            {
                repos.Update(student);
                return RedirectToAction("Index");
            }
            return View(student);
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = repos.GetStudent(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: Student/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Student student = repos.GetStudent(id);
            repos.Delete(student);
            return RedirectToAction("Index");
        }
    }
}
