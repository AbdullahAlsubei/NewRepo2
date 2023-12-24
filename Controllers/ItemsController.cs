using HomeWork_Week_1_Project.Data;
using HomeWork_Week_1_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomeWork_Week_1_Project.Controllers
{
    public class ItemsController : Controller
    {

        private readonly AppDbContext _db;

        public ItemsController(AppDbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            IEnumerable<ItemsClass> ItemsListItem = _db.Items.ToList();

            return View(ItemsListItem);
        }
    }
}
