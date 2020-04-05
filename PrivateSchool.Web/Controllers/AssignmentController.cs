using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using PagedList;
using PrivateSchool.Entities.Concrete;
using PrivateSchool.Services;

namespace PrivateSchool.Web.Controllers
{
    public class AssignmentController : Controller
    {
        private AssignmentRepository repos = new AssignmentRepository();
        private CourseRepository courseRepos = new CourseRepository();

        // GET: Assignment
        public ActionResult Index(string sortOrder,string desc,string subDate,int? page,int? userPageSize)
        {
            var assignments = repos.GetAssignments();

            ViewBag.CurrentDesc = desc;
            ViewBag.CurrentSubDate = subDate;
            ViewBag.PageSize = userPageSize;
            ViewBag.CurrentSortOrder = sortOrder;

            ViewBag.DescSortParam = string.IsNullOrEmpty(sortOrder) ? "DescDesc" : "";
            ViewBag.SubDateSortParam = sortOrder == "SubDateAsc" ? "SubDateDesc" : "SubDateAsc";

            ViewBag.DView = "badge badge-primary";
            ViewBag.SView = "badge badge-primary";

            switch (sortOrder)
            {
                case "DescDesc":
                    assignments = assignments.OrderByDescending(x => x.Description);
                    ViewBag.DView = "badge badge-danger";
                    break;
                case "SubDateAsc":
                    assignments = assignments.OrderBy(x => x.SubDate);
                    ViewBag.TView = "badge badge-success";
                    break;
                case "SubDateDesc":
                    assignments = assignments.OrderBy(x => x.SubDate);
                    ViewBag.TView = "badge badge-success";
                    break;
                default:
                    assignments = assignments.OrderBy(x => x.Description);
                    ViewBag.SView = "badge badge-success";
                    break;
            }
            //Stream Filter
            assignments = string.IsNullOrWhiteSpace(desc) ? assignments : assignments.Where(x => x.Description.ToUpper().Contains(desc.ToUpper()));

            //Type Fillter
            assignments = string.IsNullOrWhiteSpace(subDate) ? assignments : assignments.Where(x => x.SubDate.ToString().Equals(subDate));

            var pageSize = userPageSize ?? 3;
            var pageNum = page ?? 1;

            return View(assignments.ToPagedList(pageNum, pageSize));
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AssignmentId,Description,PhotoUrl,SubDate")] Assignment assignment)
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
            ViewBag.SelectedCoursesId = courseRepos
                                           .GetCourses()
                                           .Select(x =>
                                           new SelectListItem()
                                           {
                                                Value = x.CourseId.ToString(),
                                                Text = x.Stream
                                           });
            return View(assignment);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AssignmentId,Description,PhotoUrl,SubDate")] Assignment assignment,IEnumerable<int> SelectedCoursesId)
        {
            if (ModelState.IsValid)
            {
                repos.Update(assignment,SelectedCoursesId);
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
