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
        private readonly IUserService adminService;

        public AccountController(IUserService adminService)
        {
            this.adminService = adminService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Login(LoginDTO isLogin)
        {
            var result = await adminService.Login(isLogin);
            if (result is string)
                return NotFound(result);
            else
                return RedirectToAction("Index", "User");
        }

        [HttpGet]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordDTO email)
        {
            bool result = await adminService.ForgotPassword(email);
            if (!result)
            {
                ModelState.AddModelError("email", "Please give correct email...");
                return View(email);
            }
            ViewBag.email = "Check your email, password changed successfully";
            return RedirectToAction("Login");
        }
    }
}
