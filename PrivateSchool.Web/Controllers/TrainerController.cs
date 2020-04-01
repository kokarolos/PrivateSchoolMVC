using System.Linq;
using System.Net;
using System.Web.Mvc;
using PagedList;
using PrivateSchool.Entities.Concrete;
using PrivateSchool.Services;

namespace PrivateSchool.Web.Controllers
{
    public class TrainerController : Controller
    {
        private TrainerRepository repos = new TrainerRepository();

        // GET: Trainer
        public ActionResult Index(string sortOrder, string firstName,string lastName,int? minSalary,int? maxSalary,int? page,int? userPageSize)
        {
            var trainers = repos.GetTrainers();

            ViewBag.CurrentFirstName = firstName;
            ViewBag.CurrentLastName = lastName;
            ViewBag.CurrentMinSalary = minSalary;
            ViewBag.CurrentMaxSalary = maxSalary;
            ViewBag.PageSize = userPageSize;
            ViewBag.CurrentSortOrder = sortOrder;

            ViewBag.FirstNameSortParam = string.IsNullOrEmpty(sortOrder) ? "FirstNameDesc" : "";
            ViewBag.LastNameSortParam = sortOrder == "LastNameAsc" ? "LastNameDesc" : "LastNameAsc";
            ViewBag.AgeSortParam = sortOrder == "AgeAsc" ? "AgeDesc" : "AgeAsc";

            ViewBag.FNView = "badge badge-primary";
            ViewBag.LNView = "badge badge-primary";
            ViewBag.SView = "badge badge-primary";

            switch (sortOrder)
            {
                case "FirstNameDesc":
                    trainers = trainers.OrderByDescending(x => x.FirstName);
                    ViewBag.FNView = "badge badge-danger";
                    break;
                case "LastNameAsc":
                    trainers = trainers.OrderBy(x => x.LastName);
                    ViewBag.LNView = "badge badge-success";
                    break;
                case "LastNameDesc":
                    trainers = trainers.OrderByDescending(x => x.LastName);
                    ViewBag.LNView = "badge badge-danger";
                    break;
                case "AgeAsc":
                    trainers = trainers.OrderBy(x => x.Salary);
                    ViewBag.AGView = "badge badge-success";
                    break;
                case "AgeDesc":
                    trainers = trainers.OrderByDescending(x => x.Salary);
                    ViewBag.AGView = "badge badge-danger";
                    break;

                default: trainers = trainers.OrderBy(x => x.FirstName); ViewBag.FNView = "badge badge-success"; break;
            }
            //FirstName Filter
            trainers = string.IsNullOrWhiteSpace(firstName) ? trainers : trainers.Where(x => x.FirstName.ToUpper().Contains(firstName.ToUpper()));
            //LastName Fillter
            trainers = string.IsNullOrWhiteSpace(lastName) ? trainers : trainers.Where(x => x.LastName.ToUpper().Contains(lastName.ToUpper()));
            //MinAge Filter
            trainers = minSalary is null ? trainers : trainers.Where(x => x.Salary >= minSalary);
            //MaxAge Filter
            trainers = maxSalary is null ? trainers : trainers.Where(x => x.Salary <= maxSalary);

            //Pagination
            var pageSize = userPageSize ?? 3;
            var pageNum = page ?? 1;

            return View(trainers.ToPagedList(pageNum, pageSize));
        }

        // GET: Trainer/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trainer trainer = repos.GetTrainer(id);
            if (trainer == null)
            {
                return HttpNotFound();
            }
            return View(trainer);
        }

        // GET: Trainer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Trainer/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TrainerId,FirstName,LastName,Salary,PhoneNumber,Email,PhotoUrl")] Trainer trainer)
        {
            if (ModelState.IsValid)
            {
                repos.Insert(trainer);
                return RedirectToAction("Index");
            }

            return View(trainer);
        }

        // GET: Trainer/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trainer trainer = repos.GetTrainer(id);
            if (trainer == null)
            {
                return HttpNotFound();
            }
            return View(trainer);
        }

        // POST: Trainer/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TrainerId,FirstName,LastName,Salary,PhoneNumber,Email,PhotoUrl")] Trainer trainer)
        {
            if (ModelState.IsValid)
            {
                repos.Update(trainer);
                return RedirectToAction("Index");
            }
            return View(trainer);
        }

        // GET: Trainer/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trainer trainer = repos.GetTrainer(id);
            if (trainer == null)
            {
                return HttpNotFound();
            }
            return View(trainer);
        }

        // POST: Trainer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Trainer trainer = repos.GetTrainer(id);
            repos.Delete(trainer);
            return RedirectToAction("Index");
        }
    }
}
