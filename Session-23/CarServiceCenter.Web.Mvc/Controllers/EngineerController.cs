using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarServiceCenter.Web.Mvc.Controllers {
    public class EngineerController : Controller {
        // GET: EngineerController
        public ActionResult Index() {
            return View();
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
