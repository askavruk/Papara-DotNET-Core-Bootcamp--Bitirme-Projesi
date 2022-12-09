using Microsoft.AspNetCore.Mvc;

namespace PaparaBootcampBitirmeProjesi.Presentation.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
