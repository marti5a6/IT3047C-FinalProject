using Microsoft.AspNetCore.Mvc;
using MuSeek.Models;

namespace MuSeek.Controllers
{
    public class ArtistController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}