using Microsoft.AspNetCore.Mvc;

namespace PaparaBootcampBitirmeProjesi.Presentation.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
