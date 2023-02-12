using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarServiceCenter.Web.Mvc.Controllers {
    public class ServiceTasksController : Controller {
        // GET: ServiceTasksController
        public ActionResult Index() {
            return View();
        }

        // GET: ServiceTasksController/Details/5
        public ActionResult Details(int id) {
            return View();
        }

        // GET: ServiceTasksController/Create
        public ActionResult Create() {
            return View();
        }

        // POST: ServiceTasksController/Create
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

        // GET: ServiceTasksController/Edit/5
        public ActionResult Edit(int id) {
            return View();
        }

        // POST: ServiceTasksController/Edit/5
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

        // GET: ServiceTasksController/Delete/5
        public ActionResult Delete(int id) {
            return View();
        }

        // POST: ServiceTasksController/Delete/5
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
