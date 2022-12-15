using AutoMapper;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using PaparaBootcampBitirmeProjesi.BLL.EmailSender;
using PaparaBootcampBitirmeProjesi.BLL.Extensions;
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
        private readonly IApartmentRepository apartmentRepository;
        private readonly IMapper mapper;
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        private readonly IEmailSender emailSender;

        public UserService(IUserRepository userRepository, IMapper mapper, UserManager<User> userManager, SignInManager<User> signInManager, IEmailSender emailSender, IApartmentRepository apartmentRepository)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.emailSender = emailSender;
            this.apartmentRepository = apartmentRepository;
        }

        public async Task CreateUser(CreateUserDTO createUserDTO)
        {
            GenericResponse<string> response = new();
            CreateUserDTOValidator validations = new CreateUserDTOValidator();
            ValidationResult valResult = validations.Validate(createUserDTO);
            if (valResult.IsValid)
            {
                User user = new User()
                {
                    UserName = createUserDTO.FirstName + createUserDTO.LastName
                };
                mapper.Map(createUserDTO, user);
                string password = Guid.NewGuid().ToString();
                //await userRepository.Create(user);

                var apartment = apartmentRepository.ApartmentIsFull(user.Apartment);

                if (apartment != null)
                {
                    throw new Exception("Daire dolu! Lütfen boş daire seçimi yapınız.");
                }
                IdentityResult result = await userManager.CreateAsync(user, password);
                await userManager.AddToRoleAsync(user, "user");
                if (result.Succeeded)
                    emailSender.SendEmail(user.Email, "Şifre", $"Lütfen şifrenizi başka biri ile paylaşmayın...\n Şifre : {password}"); //Email sender ile kullanıcıya şifreyi mail at
            }

            else
            {
                response.ValidationMessages = valResult.Errors.GetValidationErrorMessage();
                response.Data = "Lütfen gerekli tüm alanları doldurun!";
            }
        }
        public async Task DeleteUser(string id)
        {
            User user = userRepository.FindUserById(id);
            if (user == null)
                throw new ArgumentException("Id not found");
            user.Status = Status.Passive;
            user.DeleteDate = DateTime.Now;
            await userManager.UpdateAsync(user);
        }

        public async Task<GenericResponse<string>> ForgotPassword(ForgotPasswordDTO forgotPassword)
        {
            GenericResponse<string> response = new();
            ForgotPasswordDTOValidator val = new ForgotPasswordDTOValidator();
            ValidationResult result = val.Validate(forgotPassword);

            if (!result.IsValid)
            {
                response.ValidationMessages = result.Errors.GetValidationErrorMessage();
                response.Data = "Lütfen doğru bir e-mail adresi girişi yapın!";
                return response;
            }
            else
            {
                User user = await userManager.FindByEmailAsync(forgotPassword.Email);
                if (user == null)
                {
                    response.Data = "Böyle bir kullanıcı bulunamadı.";
                    return response;
                }
                await userManager.RemovePasswordAsync(user);
                string newPassword = Guid.NewGuid().ToString();
                emailSender.SendEmail(user.Email, "Yeni şifre", $"Lütfen şifrenizi başka biri ile paylaşmayın...\n Şifre : {newPassword}");
                IdentityResult ıdentityResult = await userManager.AddPasswordAsync(user, newPassword);

                if (ıdentityResult.Succeeded)
                {
                    return new GenericResponse<string> { Data = "Yeni şifre e-mail adresinize gönderildi!" };
                }
                return new GenericResponse<string> { Data = "Yeni şifre e-mailinize adresinize gönderilemedi!" };
            }
        }

        public List<GetUsersWithApartmentDTO> GetAllUsers()
        {
            List<User> users = new List<User>();
            List<GetUsersWithApartmentDTO> usersWithApartment = new List<GetUsersWithApartmentDTO>();
            users = userRepository.GetAllWithApartment();
            mapper.Map(users, usersWithApartment);

            return usersWithApartment;
        }

        public List<GetUsersWithApartmentDTO> GetAllUsersOnTheABlock()
        {
            List<User> users = new List<User>();
            List<GetUsersWithApartmentDTO> allUserOnSameBlock = new List<GetUsersWithApartmentDTO>();
            users = userRepository.GetAllOnTheABlock();
            mapper.Map(users, allUserOnSameBlock);

            return allUserOnSameBlock;
        }

        public List<GetUsersWithApartmentDTO> GetAllUsersOnTheBBlock()
        {
            List<User> users = new List<User>();
            List<GetUsersWithApartmentDTO> allUserOnSameBlock = new List<GetUsersWithApartmentDTO>();
            users = userRepository.GetAllOnTheBBlock();
            mapper.Map(users, allUserOnSameBlock);

            return allUserOnSameBlock;
        }


        public async Task<UpdateUserDTO> GetById(string id)
        {
            UpdateUserDTO updateUser = new UpdateUserDTO();
            var user = await userManager.FindByIdAsync(id);//Identityten gelen metotları kullanmak daha hızlı işlem yapmamızı sağlıyor ve databasedeki normalize kısmını otomatik yapıyor.
            if (user != null)
            {
                if (user.Status == Status.Active)
                    updateUser = mapper.Map<UpdateUserDTO>(user);
                return updateUser;
            }
            else
                throw new Exception("Kullanıcı bulunamadı");
        }


        public async Task<object> Login(LoginDTO isLogin)
        {
            GenericResponse<string> response = new GenericResponse<string>();
            LoginDTOValidator validator = new LoginDTOValidator();
            ValidationResult result = validator.Validate(isLogin);

            if (result.IsValid)
            {
                User user = await userManager.FindByEmailAsync(isLogin.Email);
                    bool check = await userManager.CheckPasswordAsync(user, isLogin.Password);
                    if (check)
                    {
                        await signInManager.PasswordSignInAsync(user, isLogin.Password, false, false);
                        return user;
                    }
                    return "Yanlış şifre ya da e-mail! Lütfen şifrenizi ya da e-mail adresinizi kontrol edin.";
            }
            else
            {
                response.ValidationMessages = result.Errors.GetValidationErrorMessage();
                response.Data = "Lütfen gerekli tüm alanları doldurun!";
                return response;
            }
        }

        public async Task UpdateUser(UpdateUserDTO updateUserDTO)
        {
            GenericResponse<string> response = new GenericResponse<string>();
            UpdateUserDTOValidator validator = new UpdateUserDTOValidator();
            ValidationResult result = validator.Validate(updateUserDTO);

            if (result.IsValid)
            {
                var user = userRepository.FindUserById(updateUserDTO.Id);
                user.UpdateDate = DateTime.Now;
                mapper.Map(updateUserDTO, user);
                await userManager.UpdateAsync(user);
            }
            else
            {
                response.ValidationMessages = result.Errors.GetValidationErrorMessage();
                response.Data = "Lütfen gerekli tüm alanları doldurun!";
            }

        }

    }
}
