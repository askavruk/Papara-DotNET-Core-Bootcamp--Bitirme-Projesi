using AutoMapper;
using FluentValidation.Results;
using Microsoft.AspNetCore.Identity;
using PaparaBootcampBitirmeProjesi.BLL.EmailSender;
using PaparaBootcampBitirmeProjesi.BLL.Models;
using PaparaBootcampBitirmeProjesi.BLL.Models.AccountDTO;
using PaparaBootcampBitirmeProjesi.BLL.Validators;
using PaparaBootcampBitirmeProjesi.Core.Entities;
using PaparaBootcampBitirmeProjesi.Core.Enums;
using PaparaBootcampBitirmeProjesi.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcampBitirmeProjesi.BLL.Services.AdminService
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository adminRepository;
        private readonly IMapper mapper;
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        private readonly IEmailSender emailSender;

        public AdminService(IAdminRepository adminRepository, IMapper mapper, UserManager<User> userManager, SignInManager<User> signInManager, IEmailSender emailSender)
        {
            this.adminRepository = adminRepository;
            this.mapper = mapper;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.emailSender = emailSender;
        }

        public async Task CreateUser(CreateUserDTO createUserDTO)
        {
            User user = new User();
            mapper.Map(createUserDTO, user);
            await adminRepository.Create(user);
        }

        public async Task DeleteUser(string id)
        {
            User user = adminRepository.FindUserById(id);
            if (user == null) throw new ArgumentException("Id not found");
            await adminRepository.Delete(user);
        }

        public async Task<bool> ForgotPassword(ForgotPasswordDTO forgotPassword)
        {
            ForgotPasswordDTOValidator val = new ForgotPasswordDTOValidator();
            ValidationResult result = val.Validate(forgotPassword);
            if (result.IsValid)
            {
                User user = await userManager.FindByEmailAsync(forgotPassword.Email);
                if (user == null) return false;
                await userManager.RemovePasswordAsync(user);
                string newPassword = Guid.NewGuid().ToString();
                emailSender.SendEmail(user.Email, "Change Password", $"Here your password,please do not share your password nobody...\nPassword : {newPassword}");
                IdentityResult response = await userManager.AddPasswordAsync(user, newPassword);
                return response.Succeeded ? true : false;
            }
            return false;

        }

        public async Task<List<GetUserWithApartmentDTO>> GetAllUsers(string id)
        {
            List<User> users = new List<User>();
            List<GetUserWithApartmentDTO> usersWithApartment = new List<GetUserWithApartmentDTO>();
            users = await adminRepository.GetAll();
            mapper.Map(users, usersWithApartment);

            return usersWithApartment;
        }

        public async Task<UpdateUserDTO> GetById(string id)
        {
            UpdateUserDTO updateUser = new UpdateUserDTO();
            var user = adminRepository.FindUserById(id);
            if (user != null)
            {
                if (user.Status == Status.Active)
                    updateUser = mapper.Map<UpdateUserDTO>(user);
                return updateUser;
            }
            else
                throw new Exception("User not found");
        }


        public async Task<object> Login(LoginDTO isLogin)
        {
            LoginDTOValidator validator = new LoginDTOValidator();
            ValidationResult result = validator.Validate(isLogin);
            if (result.IsValid)
            {
                User user = await userManager.FindByEmailAsync(isLogin.Email);
                if (user == null) return "Please check your email and password...";
                else
                {
                    bool check = await userManager.CheckPasswordAsync(user, isLogin.Password);
                    if (check)
                        return user;
                    return "Please check your email and password...";
                }
            }
            else
            {
                string msg = string.Empty;
                foreach (var err in result.Errors)
                {
                    msg += $"{err.PropertyName} - {err.ErrorMessage} \n";
                }
                return msg;
            }
        }

        public async Task UpdateUser(UpdateUserDTO model)
        {
            UpdateUserDTO updateUser = new UpdateUserDTO();
            var user = adminRepository.FindUserById(model.Id);
            updateUser = mapper.Map<UpdateUserDTO>(user);
            adminRepository.Update(user);
        }

      
    }
}
