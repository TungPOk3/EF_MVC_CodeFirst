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
    public class SinhVienController : Controller
    {
        private readonly DbContext _dbContext;

        public SinhVienController(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            var sinhViens = await _dbContext.SinhViens.Include(sv => sv.Lop).ToListAsync();
            return View(sinhViens);
        }

        public IActionResult Create()
        {
            ViewBag.Lops = _dbContext.Lops.ToList();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Sinhvien sinhVien)
        {
            if (ModelState.IsValid)
            {
                _dbContext.SinhViens.Add(sinhVien);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.Lops = _dbContext.Lops.ToList();
            return View(sinhVien);
        }
    }
}
