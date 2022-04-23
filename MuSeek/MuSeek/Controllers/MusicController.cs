using Microsoft.AspNetCore.Mvc;
using MuSeek.Models;

namespace MuSeek.Controllers
{
    public class MusicController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}