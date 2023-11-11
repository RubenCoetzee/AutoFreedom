using AutoFreedom.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AutoFreedom.Controllers
{
    public class StoreController : Controller
    {
        private readonly AfDbContext _dbContext;

        public StoreController(AfDbContext _dbContext)
        {
            this._dbContext = _dbContext;
        }

        public IActionResult Index()
        {
            var stores = _dbContext.Stores.ToList();
            return View(stores);
        }
    }
}
