using System.Linq;
using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;
using PrivateSchool.Entities.Concrete;
using PrivateSchool.Services;

namespace PrivateSchool.Web.Controllers
{
    public class StudentController : Controller
    {
        private StudentRepository repos = new StudentRepository();

        // GET: Student
        public ActionResult Index(string FirstName)
        {
            if(string.IsNullOrWhiteSpace(FirstName))
            {
                return View(repos.GetStudents());
            }
            else
            {
                return View(repos.GetStudents().Where(x => x.FirstName.Equals(FirstName)));
            }
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
        public ActionResult Create([Bind(Include = "StudentId,FirstName,LastName,DateOfBirth,TuitionFees")] Student student)
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
        public ActionResult Edit([Bind(Include = "StudentId,FirstName,LastName,DateOfBirth,TuitionFees")] Student student)
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
