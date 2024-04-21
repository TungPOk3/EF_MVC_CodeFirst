using EF_MVC_CodeFirst.Data;
using EF_MVC_CodeFirst.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_MVC_CodeFirst.Controllers
{
    public class LopController : Controller
    {
        
        private readonly DbContextMVC _dbContext;

        public LopController(DbContextMVC dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            var lops = await _dbContext.Lops.Include(l => l.Khoa).ToListAsync();
            return View(lops);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Lop lop)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Lops.Add(lop);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(lop);
        }
    }
}
