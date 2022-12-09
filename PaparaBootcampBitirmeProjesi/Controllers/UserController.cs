using Microsoft.AspNetCore.Mvc;
using PaparaBootcampBitirmeProjesi.BLL.Services.AdminService;
using System.Threading.Tasks;

namespace PaparaBootcampBitirmeProjesi.Presentation.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("BlockAList")]
        public IActionResult BlockBListPartial(string A)
        {
            var blokAUsers =  userService.GetAllUsersOnTheBlock(A);
            return PartialView(blokAUsers);
        }

        [HttpGet]
        [Route("BlockBList")]
        public IActionResult BlockAListPartial(string B)
        {
            var blokBUsers = userService.GetAllUsersOnTheBlock(B);
            return PartialView(blokBUsers);
        }

        [HttpGet]
        [Route("AllUsers")]
        public IActionResult AllOfThemPartial(string B)
        {
            var allOfThem = userService.GetAllUsers();
            return PartialView(allOfThem);
        }


    }
}
