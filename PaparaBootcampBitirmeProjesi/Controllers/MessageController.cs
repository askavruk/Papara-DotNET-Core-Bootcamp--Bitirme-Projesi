using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PaparaBootcampBitirmeProjesi.BLL.Models.MessageDTO;
using PaparaBootcampBitirmeProjesi.BLL.Services.MessageService;
using PaparaBootcampBitirmeProjesi.Core.Entities;
using System.Threading.Tasks;

namespace PaparaBootcampBitirmeProjesi.Presentation.Controllers
{
    public class MessageController : Controller
    {
        private readonly IMessageService messageService;
        private readonly UserManager<User> userManager;

        public MessageController(IMessageService messageService, UserManager<User> userManager)
        {
            this.messageService = messageService;
            this.userManager = userManager;
        }

        public async Task<IActionResult> Inbox()
        {
            User user = await userManager.GetUserAsync(HttpContext.User);
            string mail = user.Email;
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
        public async Task<IActionResult> NewMessage(CreateMessageDTO createMessage)
        {
            User user = await userManager.GetUserAsync(HttpContext.User);
            createMessage.User.Id = user.Id;
            await messageService.CreateMessage(createMessage);
            return RedirectToAction("Sendbox");
        }

        public async Task<IActionResult> Sendbox()
        {
            User user = await userManager.GetUserAsync(HttpContext.User);
            string mail = user.Email;
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
