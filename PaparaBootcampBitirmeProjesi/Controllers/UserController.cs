using Microsoft.AspNetCore.Mvc;
using PaparaBootcampBitirmeProjesi.BLL.Models;
using PaparaBootcampBitirmeProjesi.BLL.Models.UserDTO;
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
        public IActionResult BlockAList(string A)
        {
            var blokAUsers = userService.GetAllUsersOnTheBlock(A);
            return View(blokAUsers);
        }

        [HttpGet]
        [Route("BlockBList")]
        public IActionResult BlockBList(string B)
        {
            var blokBUsers = userService.GetAllUsersOnTheBlock(B);
            return View(blokBUsers);
        }

        [HttpGet]
        [Route("AllUsers")]
        public IActionResult AllOfThem()
        {
            var allOfThem = userService.GetAllUsers();
            return View(allOfThem);
        }

        [HttpGet]
        public IActionResult CreateUserParital()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateUser(CreateUserDTO createUserDTO)
        {
            if (createUserDTO == null)
                return NotFound();
            else
                userService.CreateUser(createUserDTO);
                return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateUser(string id)
        {
            UpdateUserDTO updateUserDTO = await userService.GetById(id);
            return View();
        }

        [HttpPost]
        public IActionResult UpdateUser(UpdateUserDTO updateUser)
        {
            userService.UpdateUser(updateUser);
            return RedirectToAction("Index");
        }


    }
}
