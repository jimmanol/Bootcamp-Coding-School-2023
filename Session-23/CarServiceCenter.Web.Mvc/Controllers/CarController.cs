using CarServiceCenter.EF.Repositories;
using CarServiceCenter.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarServiceCenter.Web.Mvc.Controllers {
    public class CarController : Controller {

        //properties
        private readonly IEntityRepo<Car> _carRepo;

        //constructor

        public CarController(IEntityRepo<Car> carRepo) {
            _carRepo= carRepo;
        }
        // GET: CarController
        public ActionResult Index() {
            var dbCars = _carRepo.GetAll();
            return View(dbCars);
        }

        // GET: CarController/Details/5
        public ActionResult Details(int id) {
            return View();
        }

        // GET: CarController/Create
        public ActionResult Create() {
            return View();
        }

        // POST: CarController/Create
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

        // GET: CarController/Edit/5
        public ActionResult Edit(int id) {
            return View();
        }

        // POST: CarController/Edit/5
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

        // GET: CarController/Delete/5
        public ActionResult Delete(int id) {
            return View();
        }

        // POST: CarController/Delete/5
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
