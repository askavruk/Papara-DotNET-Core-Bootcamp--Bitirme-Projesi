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
        public IActionResult BlockAList(string A)
        {
            var blokAUsers = userService.GetAllUsersOnTheBlock(A);
            return View(blokAUsers);
        }

        public IActionResult BlockBList(string B)
        {
            var blokBUsers = userService.GetAllUsersOnTheBlock(B);
            return View(blokBUsers);
        }

        public IActionResult AllUsers()
        {
            var allOfThem = userService.GetAllUsers();
            return View(allOfThem);
        }

        public IActionResult CreateUser()
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


        public IActionResult UpdateUser(string id)
        {
            UpdateUserDTO updateUserDTO = userService.GetById(id);
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
