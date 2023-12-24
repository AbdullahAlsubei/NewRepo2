using HomeWork_Week_1_Project.Data;
using HomeWork_Week_1_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomeWork_Week_1_Project.Controllers
{
    public class CategoriesController : Controller
    {


        //4- add the following
        //start
        private readonly AppDbContext _db;

        public CategoriesController(AppDbContext db) 
        { 
            _db = db;
        }

        //end

        public IActionResult Index()
        {
            //5- add ienumerable to fill data from table in server
            IEnumerable<CategoriesClass> CategoriesListItem = _db.Categories.ToList();
           
            //6- return list to view page 
            return View(CategoriesListItem);

            //return View();
        }

        public IActionResult New()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult New(CategoriesClass postedcategories)
        {

            if(postedcategories.CategoryName=="100")
            {
                ModelState.AddModelError("CategoryName", "Name cant be number");
            }

            if (ModelState.IsValid) { 
            _db.Categories.Add(postedcategories);
            _db.SaveChanges();
                TempData["Sucsess"]= "تم إضافة الحقل";
           //نقل الى اندكس في نفس الكنترولر
            return RedirectToAction("Index");

                //البقاء في نفس الصفحة
                //return View();

                //الانتقال لفيو في كنترولر اخر
                // return RedirectToAction("Index","HOME");

            }

            else
            {
                return View(postedcategories);
            }

        }


        public IActionResult Edit(int Id)
        {

            if (Id == 0 ||Id == null)
            {
                return NotFound();
            }

            var CategoryTable = _db.Categories.Find(Id);
            if (CategoryTable == null) 
            {
                return NotFound();
            }

            return View(CategoryTable);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CategoriesClass postedcategories)
        {

            if (postedcategories.CategoryName == "100")
            {
                ModelState.AddModelError("CategoryName", "Name cant be number");
            }

            if (ModelState.IsValid)
            {
                _db.Categories.Update(postedcategories);
                _db.SaveChanges();
                TempData["Sucsess"] = "تم تعديل الحقل";
                //نقل الى اندكس في نفس الكنترولر
                return RedirectToAction("Index");

                //البقاء في نفس الصفحة
                //return View();

                //الانتقال لفيو في كنترولر اخر
                // return RedirectToAction("Index","HOME");

            }

            else
            {
                return View(postedcategories);
            }

        }

        public IActionResult Delete(int CategoryId)
        {

            if (CategoryId == 0)
            {
                return NotFound();
            }

            var CategoryTable = _db.Categories.Find(CategoryId);
            if (CategoryTable == null)
            {
                return NotFound();
            }

            return View(CategoryTable);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(CategoriesClass postedcategories)
        {
                _db.Categories.Remove(postedcategories);
                _db.SaveChanges();
            TempData["Sucsess"] = "تم مسح الحقل";
            return RedirectToAction("Index");
        }
    }
}
