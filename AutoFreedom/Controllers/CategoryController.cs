using AutoFreedom.Data;
using Microsoft.AspNetCore.Mvc;

namespace AutoFreedom.Controllers
{
    public class CategoryController : Controller
    {

        private readonly AfDbContext _dbContext;

        public CategoryController(AfDbContext _dbContext)
        {
            this._dbContext = _dbContext;
        }


        public IActionResult Index()
        {
            var categories = _dbContext.Categories.ToList();
            return View(categories);
        }


    }
}
