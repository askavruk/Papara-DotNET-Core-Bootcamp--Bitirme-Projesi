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
        public IActionResult BlockAList(string BlockA)
        {
            BlockA = "A";
            var blokAUsers = userService.GetAllUsersOnTheBlock(BlockA);
            return View(blokAUsers);
        }

        public IActionResult BlockBList(string BlockB)
        {
            BlockB = "B";
            var blokBUsers = userService.GetAllUsersOnTheBlock(BlockB);
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
        public async Task<IActionResult> CreateUser(CreateUserDTO createUserDTO)
        {
            if (createUserDTO == null)
                return NotFound();
            else
               await userService.CreateUser(createUserDTO);
            return RedirectToAction("Index");
        }

        public IActionResult UpdateOrDeleteUser()
        {
            var allOfThem = userService.GetAllUsers();
            return View(allOfThem);
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

        public async Task<IActionResult> DeleteUser(string id)
        {
            await userService.DeleteUser(id);
            return RedirectToAction("UpdateOrDeleteUser");
        }



    }
}
