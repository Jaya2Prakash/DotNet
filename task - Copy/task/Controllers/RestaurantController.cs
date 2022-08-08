using Microsoft.AspNetCore.Mvc;
using task.Data;
using task.Models;

namespace task.Controllers
{
    public class RestaurantController : Controller
    {
        private readonly Application db;


        public RestaurantController(Application _db)
        {
            db = _db;
        }

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Signup(Property obj)
        {
            if(ModelState.IsValid)
            {
                db.properties.Add(obj);
                db.SaveChanges();
                TempData["success"] = "Successfully Uploaded";
                return RedirectToAction("Index");
            }
            return View(obj);
            
        }
    }
}
