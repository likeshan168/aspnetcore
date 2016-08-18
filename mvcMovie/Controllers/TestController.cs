using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mvcMovie.Data;

namespace mvcMovie.Controllers
{
    public class TestController : Controller
    {

        private readonly ApplicationDbContext _context;

        public TestController(ApplicationDbContext context)
        {
            _context = context;
        }

        //get users
        public async Task<IActionResult> Index()
        {
            return View(await _context.UserList.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}