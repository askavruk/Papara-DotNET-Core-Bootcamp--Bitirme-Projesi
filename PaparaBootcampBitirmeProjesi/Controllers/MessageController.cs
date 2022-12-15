using Microsoft.AspNetCore.Mvc;
using PaparaBootcampBitirmeProjesi.BLL.Models.MessageDTO;
using PaparaBootcampBitirmeProjesi.BLL.Services.MessageService;

namespace PaparaBootcampBitirmeProjesi.Presentation.Controllers
{
    public class MessageController : Controller
    {
        private readonly IMessageService messageService;

        public MessageController(IMessageService messageService)
        {
            this.messageService = messageService;
        }

        public IActionResult Inbox(string mail)
        {
            messageService.GetListInbox(mail);
            return View();
        }

        public IActionResult GetMessageDetails(string id)
        {
            messageService.GetMessageDetails(id);
            return View();
        }

        public IActionResult NewMessage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewMessage(CreateMessageDTO createMessage)
        {
            messageService.CreateMessage(createMessage);
            return RedirectToAction("Sendbox");
        }

        public IActionResult Sendbox(string mail)
        {
            messageService.GetListSendbox(mail);
            return View();
        }

        [HttpDelete]
        public IActionResult DeleteMessage(string id)
        {
            messageService.DeleteMessage(id);
            return RedirectToAction("Inbox");
        }
    }
}
