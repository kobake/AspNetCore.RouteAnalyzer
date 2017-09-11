using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.RouteAnalyzer.SampleWebProject.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult World()
        {
            return View();
        }
    }
}