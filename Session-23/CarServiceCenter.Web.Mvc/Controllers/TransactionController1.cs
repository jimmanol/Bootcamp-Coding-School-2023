using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarServiceCenter.Web.Mvc.Controllers {
    public class TransactionController1 : Controller {
        // GET: TransactionController1
        public ActionResult Index() {
            return View();
        }

        // GET: TransactionController1/Details/5
        public ActionResult Details(int id) {
            return View();
        }

        // GET: TransactionController1/Create
        public ActionResult Create() {
            return View();
        }

        // POST: TransactionController1/Create
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

        // GET: TransactionController1/Edit/5
        public ActionResult Edit(int id) {
            return View();
        }

        // POST: TransactionController1/Edit/5
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

        // GET: TransactionController1/Delete/5
        public ActionResult Delete(int id) {
            return View();
        }

        // POST: TransactionController1/Delete/5
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
