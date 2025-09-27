using BookWebStore.Data;
using BookWebStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookWebStore.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        //private static List<Category> _categories = new List<Category>();
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var categories = _db.Categories.ToList();
            

            return View(categories);
        }
    }
}
