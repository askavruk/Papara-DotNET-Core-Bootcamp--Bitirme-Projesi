using Microsoft.AspNetCore.Mvc;

namespace PaparaBootcampBitirmeProjesi.Presentation.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
