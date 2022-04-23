using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MuSeek.Models;
using System.Diagnostics;


namespace MuSeek.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
