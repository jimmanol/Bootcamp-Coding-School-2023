using CarServiceCenter.EF.Repositories;
using CarServiceCenter.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarServiceCenter.Web.Mvc.Controllers {
    public class EngineerController : Controller {
        // properties
        private readonly IEntityRepo<Manager> _managerRepo;
        private readonly IEntityRepo<Engineer> _engineerRepo;

        // constructors
        public EngineerController(IEntityRepo<Manager> managerRepo, IEntityRepo<Engineer> engineerRepo) {
            _managerRepo = managerRepo;
            _engineerRepo = engineerRepo;
        }

        // GET: EngineerController
        public ActionResult Index() {
            var dbEngineers = _engineerRepo.GetAll();
            return View(dbEngineers);
        }

        // GET: EngineerController/Details/5
        public ActionResult Details(int id) {
            return View();
        }

        // GET: EngineerController/Create
        public ActionResult Create() {
            return View();
        }

        // POST: EngineerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            }
            catch {
                return View();
            }
        }

        // GET: EngineerController/Edit/5
        public ActionResult Edit(int id) {
            return View();
        }

        // POST: EngineerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            }
            catch {
                return View();
            }
        }

        // GET: EngineerController/Delete/5
        public ActionResult Delete(int id) {
            return View();
        }

        // POST: EngineerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            }
            catch {
                return View();
            }
        }
    }
}
