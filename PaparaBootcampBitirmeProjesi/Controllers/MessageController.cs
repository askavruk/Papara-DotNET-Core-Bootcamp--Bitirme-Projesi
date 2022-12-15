using Microsoft.AspNetCore.Mvc;

namespace PaparaBootcampBitirmeProjesi.Presentation.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Inbox(string mail)
        {
            
            return View();
        }

        public IActionResult GetMessageDetails(string id)
        {
            return View();
        }

        public IActionResult NewMessage()
        {
            HttpContext.Session.Set
            return RedirectToAction("MailGonder");
            return View();
        }

        public IActionResult Sendbox()
        {
            return View();
        }
    }
}
