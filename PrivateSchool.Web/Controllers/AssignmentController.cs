using System.Net;
using System.Web.Mvc;
using PrivateSchool.Entities.Concrete;
using PrivateSchool.Services;

namespace PrivateSchool.Web.Controllers
{
    public class AssignmentController : Controller
    {
        private AssignmentRepository repos = new AssignmentRepository();

        // GET: Assignment
        public ActionResult Index()
        {
            return View(repos.GetAssignments());
        }

        // GET: Assignment/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assignment assignment = repos.GetAssignment(id);
            if (assignment == null)
            {
                return HttpNotFound();
            }
            return View(assignment);
        }

        // GET: Assignment/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Assignment/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AssignmentId,Description")] Assignment assignment)
        {
            if (ModelState.IsValid)
            {
                repos.Insert(assignment);
                return RedirectToAction("Index");
            }

            return View(assignment);
        }

        // GET: Assignment/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assignment assignment = repos.GetAssignment(id);
            if (assignment == null)
            {
                return HttpNotFound();
            }
            return View(assignment);
        }

        // POST: Assignment/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AssignmentId,Description")] Assignment assignment)
        {
            if (ModelState.IsValid)
            {
                repos.Update(assignment);
                return RedirectToAction("Index");
            }
            return View(assignment);
        }

        // GET: Assignment/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assignment assignment = repos.GetAssignment(id);
            if (assignment == null)
            {
                return HttpNotFound();
            }
            return View(assignment);
        }

        // POST: Assignment/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Assignment assignment = repos.GetAssignment(id);
            repos.Delete(assignment);
            return RedirectToAction("Index");
        }
    }
}
