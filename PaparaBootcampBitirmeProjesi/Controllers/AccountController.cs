using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PaparaBootcampBitirmeProjesi.BLL.Models.AccountDTO;
using PaparaBootcampBitirmeProjesi.BLL.Services.AdminService;
using PaparaBootcampBitirmeProjesi.Core.Entities;
using System.Threading.Tasks;

namespace PaparaBootcampBitirmeProjesi.Presentation.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        private readonly IUserService userService;

        public AccountController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Login(LoginDTO isLogin)
        {
            if (ModelState.IsValid)
            {
                var result = await userService.Login(isLogin);
                return RedirectToAction("Index", "User");
            }
             return View("Login");
        }

        [HttpGet]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordDTO forgotPassword)
        {
            if (ModelState.IsValid)
            {
                var result = await userService.ForgotPassword(forgotPassword);
            }

            return RedirectToAction("Login");
        }
    }
}
