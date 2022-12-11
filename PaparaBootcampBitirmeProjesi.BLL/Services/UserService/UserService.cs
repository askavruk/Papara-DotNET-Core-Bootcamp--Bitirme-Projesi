using AutoMapper;
using FluentValidation.Results;
using Microsoft.AspNetCore.Identity;
using PaparaBootcampBitirmeProjesi.BLL.EmailSender;
using PaparaBootcampBitirmeProjesi.BLL.Models;
using PaparaBootcampBitirmeProjesi.BLL.Models.AccountDTO;
using PaparaBootcampBitirmeProjesi.BLL.Models.UserDTO;
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
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        private readonly IEmailSender emailSender;

        public UserService(IUserRepository userRepository, IMapper mapper, UserManager<User> userManager, SignInManager<User> signInManager, IEmailSender emailSender)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.emailSender = emailSender;
        }

        public async Task CreateUser(CreateUserDTO createUserDTO)
        {
            User user = new User();
            mapper.Map(createUserDTO, user);
            await userRepository.Create(user);
        }

        public async Task DeleteUser(string id)
        {
            User user = userRepository.FindUserById(id);
            if (user == null) throw new ArgumentException("Id not found");
            await userRepository.Delete(user);
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

        public List<GetUsersWithApartmentDTO> GetAllUsers()
        {
            List<User> users = new List<User>();
            List<GetUsersWithApartmentDTO> usersWithApartment = new List<GetUsersWithApartmentDTO>();
            users = userRepository.GetAllWithApartment();
            mapper.Map(users, usersWithApartment);

            return usersWithApartment;
        }

        public List<GetUsersWithApartmentDTO> GetAllUsersOnTheBlock(string block)
        {
            List<User> users = new List<User>();
            List<GetUsersWithApartmentDTO> allUserOnSameBlock = new List<GetUsersWithApartmentDTO>();
            users = userRepository.GetAllOnTheBlock(block);
            mapper.Map(users, allUserOnSameBlock);

            return allUserOnSameBlock;
        }

        public UpdateUserDTO GetById(string id)
        {
            UpdateUserDTO updateUser = new UpdateUserDTO();
            var user = userRepository.FindUserById(id);
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
                await userManager.AddPasswordAsync(user, "admin123");

                if (user == null) return "Please check your email and password...";
                else
                {
                    bool check = await userManager.CheckPasswordAsync(user, isLogin.Password);
                    if (check)
                    {
                        await signInManager.PasswordSignInAsync(user, isLogin.Password, false, false);
                        return user;

                    }
                    return "Please check your email and password...";
                }
            }
            else
            {
                //result.Errors.getvalidationErrors(); => Extension method olarak yönetilebilir.
                string msg = string.Empty;
                foreach (var err in result.Errors)
                {
                    msg += $"{err.PropertyName} - {err.ErrorMessage} \n";
                }
                return msg;
            }
        }

        public void UpdateUser(UpdateUserDTO model)
        {
            var user = userRepository.FindUserById(model.Id);
            user.UpdateDate = DateTime.Now;
            mapper.Map(model, user);
            userRepository.Update(user);
        }


    }
    //public class UpdateResponse
    //{
    //    public string ErrorMessa { get; set; }
    //    public User User { get; set; }
    //}
}
