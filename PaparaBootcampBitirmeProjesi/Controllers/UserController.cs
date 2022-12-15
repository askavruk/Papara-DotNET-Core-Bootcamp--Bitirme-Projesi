using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PaparaBootcampBitirmeProjesi.BLL.Models;
using PaparaBootcampBitirmeProjesi.BLL.Models.UserDTO;
using PaparaBootcampBitirmeProjesi.BLL.Services.AdminService;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PaparaBootcampBitirmeProjesi.Presentation.Controllers
{
    [Authorize(Roles = "admin")]
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

        public IActionResult BlockAList()
        {
            if (ModelState.IsValid)
            {
                var blokAUsers = userService.GetAllUsersOnTheABlock();
                return View(blokAUsers);
            }
            return RedirectToAction("Index");
        }

        public IActionResult BlockBList()
        {
            if (ModelState.IsValid)
            {
                var blokBUsers = userService.GetAllUsersOnTheBBlock();
                return View(blokBUsers); 
            }
            return RedirectToAction("Index");
        }

        public IActionResult AllUsers()
        {
            if (ModelState.IsValid)
            {
                var allOfThem = userService.GetAllUsers();
                return View(allOfThem); 
            }
            return RedirectToAction("Index");
        }

        public IActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserDTO createUserDTO)
        {
            if (ModelState.IsValid)
            {
                await userService.CreateUser(createUserDTO);
                return RedirectToAction("Index"); 
            }
            return View();
        }

        public IActionResult UpdateOrDeleteUser()
        {
            if (ModelState.IsValid)
            {
                var allOfThem = userService.GetAllUsers();
                return View(allOfThem); 
            }
            return View();
        }


        public async Task<IActionResult> UpdateUser(string id)
        {
            if (ModelState.IsValid)
            {
                UpdateUserDTO updateUserDTO = await userService.GetById(id);
                return View(updateUserDTO); 
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateUser(UpdateUserDTO updateUser)
        {
            if (ModelState.IsValid)
            {
                await userService.UpdateUser(updateUser);
                return RedirectToAction("Index"); 
            }
            return View();
        }

        public async Task<IActionResult> DeleteUser(string id)
        {
            if (ModelState.IsValid)
            {
                await userService.DeleteUser(id);
                return RedirectToAction("UpdateOrDeleteUser"); 
            }
            return View();
        }



    }
}
