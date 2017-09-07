using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCore.RouteAnalyzer.Controllers
{
    public class RouteAnalyzer_MainController : Controller
    {
        private readonly IRouteAnalyzer m_routeAnalyzer;

        public RouteAnalyzer_MainController(IRouteAnalyzer routeAnalyzer)
        {
            m_routeAnalyzer = routeAnalyzer;
        }

        public IActionResult ShowAllRoutes()
        {
            var infos = m_routeAnalyzer.GetAllRouteInformations();
            string ret = "";
            foreach (var info in infos)
            {
                ret += info.ToString() + "\n";
            }
            return Content(ret);
        }
    }
}
