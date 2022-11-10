using GroupProject.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupProject.Controllers
{
    public class ItemsController : Controller
    {
        private readonly UserDBContext _context;

        public ItemsController(UserDBContext context)
        {
            _context = context;
        }

        // GET: Item
        public async Task<IActionResult> Index()
        {
            //var userDbContext = _context.ItemsModel.
            return View();
        }
    }
}
