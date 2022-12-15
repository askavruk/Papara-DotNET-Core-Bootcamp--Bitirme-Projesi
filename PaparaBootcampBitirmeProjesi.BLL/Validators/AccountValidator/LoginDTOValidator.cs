using FluentValidation;
using PaparaBootcampBitirmeProjesi.BLL.Models.AccountDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcampBitirmeProjesi.BLL.Validators
{
    public class LoginDTOValidator : AbstractValidator<LoginDTO>
    {
        public LoginDTOValidator()
        {
            RuleFor(a => a.Email).NotEmpty().WithMessage("Email does not empty").NotNull().WithMessage("Email does not null").EmailAddress().WithMessage("Please check your e mail adress.");
            RuleFor(a => a.Password).NotEmpty().WithMessage("Password does not empty").NotNull().WithMessage("Password does not null");
        }
    }
}
