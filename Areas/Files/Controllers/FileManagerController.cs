using Microsoft.AspNetCore.Mvc;

namespace SummerEditor.Areas.Files.Controllers
{
    public class FileManagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
