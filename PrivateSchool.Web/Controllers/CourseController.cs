using System.Linq;
using System.Net;
using System.Web.Mvc;
using PagedList;
using PrivateSchool.Entities.Concrete;
using PrivateSchool.Services;
using System;
using Type = PrivateSchool.Entities.Concrete.Type;
using System.Collections.Generic;

namespace PrivateSchool.Web.Controllers
{
    public class CourseController : Controller
    {
        private CourseRepository repos = new CourseRepository();
        private StudentRepository stRepos = new StudentRepository();
        private TrainerRepository trRepos = new TrainerRepository();
        private AssignmentRepository asRepos = new AssignmentRepository();

        // GET: Course
        public ActionResult Index(string sortOrder,string stream,string type,string startingDate,string endingDate,int? page,int? userPageSize)
        {
            var courses = repos.GetCourses();

            ViewBag.CurrentStream = stream;
            ViewBag.CurrentType = type;
            ViewBag.CurrentStratingDate = startingDate;
            ViewBag.CurrentEndingDate = endingDate;
            ViewBag.PageSize = userPageSize;
            ViewBag.CurrentSortOrder = sortOrder;

            ViewBag.StreamSortParam = string.IsNullOrEmpty(sortOrder) ? "StreamDesc" : "";
            ViewBag.TypeSortParam = sortOrder == "TypeAsc" ? "TypeDesc" : "TypeAsc";
            ViewBag.StartingDateSortParam = sortOrder == "StartingDateAsc" ? "StartingDateDesc" : "StartingDateAsc";
            ViewBag.EndingDateSortParam = sortOrder == "EndingDateAsc" ? "EndingDateDesc" : "EndingDateAsc";

            ViewBag.SView = "badge badge-primary";
            ViewBag.TView = "badge badge-primary";
            ViewBag.SDView = "badge badge-primary";
            ViewBag.EDView = "badge badge-primary";

            switch (sortOrder)
            {
                case "StreamDesc":
                    courses = courses.OrderByDescending(x => x.Stream);
                    ViewBag.SView = "badge badge-danger";
                    break;
                case "TypeAsc":
                    courses = courses.OrderBy(x => x.Type);
                    ViewBag.TView = "badge badge-success";
                    break;
                case "TypeDesc":
                    courses = courses.OrderBy(x => x.Type);
                    ViewBag.TView = "badge badge-success";
                    break;
                case "StartingDateAsc":
                    courses = courses.OrderBy(x => x.StartingDate);
                    ViewBag.SDView = "badge badge-danger";
                    break;
                case "StartingDateDesc":
                    courses = courses.OrderByDescending(x => x.StartingDate);
                    ViewBag.SDView = "badge badge-success";
                    break;
                case "EndingDateAsc":
                    courses = courses.OrderBy(x => x.EndingDate);
                    ViewBag.EDView = "badge badge-danger";
                    break;
                case "EndingDateDesc":
                    courses = courses.OrderByDescending(x => x.EndingDate);
                    ViewBag.EDView = "badge badge-danger";
                    break;

                default: courses = courses.OrderBy(x => x.Stream);
                    ViewBag.SView = "badge badge-success"; 
                    break;
            }
            //Stream Filter
            courses = string.IsNullOrWhiteSpace(stream) ? courses : courses.Where(x => x.Stream.ToUpper().Contains(stream.ToUpper()));
            //Type Fillter
            courses = string.IsNullOrWhiteSpace(type) ? courses : courses.Where(x => x.Type.ToString().ToUpper().Contains(type.ToUpper()));
            //StartingDate Filter
            courses = string.IsNullOrWhiteSpace(startingDate) ? courses : courses.Where(x => x.StartingDate.ToString().Contains(startingDate));
            //StartingDate Filter
            courses = string.IsNullOrWhiteSpace(startingDate) ? courses : courses.Where(x => x.EndingDate.ToString().Contains(startingDate));

            var pageSize = userPageSize ?? 3;
            var pageNum = page ?? 1;

            return View(courses.ToPagedList(pageNum, pageSize));
        }

        // GET: Course/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course course = repos.GetCourse(id);
            if (course == null)
            {
                return HttpNotFound();
            }
            return View(course);
        }

        // GET: Course/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Course/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CourseId,Stream,Type,StartinDate,EndingDate,PhotoUrl")] Course course)
        {
            if (ModelState.IsValid)
            {
                repos.Insert(course);
                return RedirectToAction("Index");
            }
            return View(course);
        }

        // GET: Course/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course course = repos.GetCourse(id);
            if (course == null)
            {
                return HttpNotFound();
            }
            ViewBag.SelectedStudentsIds = stRepos.GetStudents()
                                          .Select(x => new SelectListItem()
                                          {
                                              Value = x.StudentId.ToString(), Text = string.Format("{0} {1}", x.FirstName, x.LastName)
                                          });
            ViewBag.SelectedTrainersIds = trRepos.GetTrainers()
                                          .Select(x => new SelectListItem()
                                          {
                                              Value = x.TrainerId.ToString(),
                                              Text = string.Format("{0} {1}", x.FirstName, x.LastName)
                                          });
            ViewBag.SelectedAssignmentsIds = asRepos.GetAssignments()
                                          .Select(x => new SelectListItem()
                                          {
                                              Value = x.AssignmentId.ToString(),
                                              Text = x.Description
                                          });

            return View(course);
        }

        // POST: Course/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CourseId,Stream,Type,StartinDate,EndingDate,PhotoUrl")] Course course, IEnumerable<int> SelectedStudentsIds, IEnumerable<int> SelectedTrainersIds, IEnumerable<int> SelectedAssignmentsIds)
        {
            if (ModelState.IsValid)
            {
                repos.Update(course,SelectedStudentsIds,SelectedTrainersIds, SelectedAssignmentsIds);
                return RedirectToAction("Index");
            }
            return View(course);
        }

        // GET: Course/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course course = repos.GetCourse(id);
            if (course == null)
            {
                return HttpNotFound();
            }
            return View(course);
        }

        // POST: Course/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var course = repos.GetCourse(id);
            repos.Delete(course);
            return RedirectToAction("Index");
        }
    }
}
