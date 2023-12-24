using HomeWork_Week_1_Project.Data;
using HomeWork_Week_1_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomeWork_Week_1_Project.Controllers
{
    public class ItemsPropartiesController : Controller
    {

        private readonly AppDbContext _db;

        public ItemsPropartiesController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<ItemsPropartiesClass> ItemsPropartiesListItem = _db.ItemsProparties.ToList();   

            return View(ItemsPropartiesListItem);
        }
    }
}
