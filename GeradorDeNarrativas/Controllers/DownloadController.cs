using Microsoft.AspNetCore.Mvc;

namespace GeradorDeNarrativas.Controllers
{
    public class DownloadController : Controller
    {
        public IActionResult DownloadNarrativa()
        {
            return View();
        }
    }
}
