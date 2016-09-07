using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AzureWebsiteAspNetCoreFramework.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            Trace.TraceError("This is an error message from About");

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            Trace.TraceError("This is an error message from Contact");

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
