using AutoMapper;
using FluentValidation.Results;
using Microsoft.AspNetCore.Identity;
using PaparaBootcampBitirmeProjesi.BLL.EmailSender;
using PaparaBootcampBitirmeProjesi.BLL.Extensions;
using PaparaBootcampBitirmeProjesi.BLL.Models;
using PaparaBootcampBitirmeProjesi.BLL.Models.AccountDTO;
using PaparaBootcampBitirmeProjesi.BLL.Validators;
using PaparaBootcampBitirmeProjesi.Core.Entities;
using System;
using System.Threading.Tasks;

namespace PaparaBootcampBitirmeProjesi.BLL.Services.AccountService
{
    public class AccountService : IAccountService
    {
        private readonly IMapper mapper;
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        private readonly IEmailSender emailSender;

        public AccountService(IMapper mapper, UserManager<User> userManager, SignInManager<User> signInManager, IEmailSender emailSender)
        {
            this.mapper = mapper;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.emailSender = emailSender;
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
    }
}
