﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PaparaBootcampBitirmeProjesi.BLL.Models;
using PaparaBootcampBitirmeProjesi.BLL.Models.UserDTO;
using PaparaBootcampBitirmeProjesi.BLL.Services.AdminService;
using System.Collections.Generic;
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
        public IActionResult BlockAList()
        {
            var blokAUsers = userService.GetAllUsersOnTheABlock();
            return View(blokAUsers);
        }

        public IActionResult BlockBList()
        {
            var blokBUsers = userService.GetAllUsersOnTheBBlock();
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


        public async Task<IActionResult> UpdateUser(string id)
        {
            UpdateUserDTO updateUserDTO =await userService.GetById(id);
            return View(updateUserDTO);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateUser(UpdateUserDTO updateUser)
        {
            await userService.UpdateUser(updateUser);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteUser(string id)
        {
            await userService.DeleteUser(id);
            return RedirectToAction("UpdateOrDeleteUser");
        }



    }
}
