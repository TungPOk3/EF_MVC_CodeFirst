using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_MVC_CodeFirst.Controllers
{
    public class KhoaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
