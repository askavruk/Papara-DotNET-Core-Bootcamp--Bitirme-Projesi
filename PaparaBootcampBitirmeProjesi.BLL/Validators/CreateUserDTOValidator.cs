using FluentValidation;
using PaparaBootcampBitirmeProjesi.BLL.Models;
using PaparaBootcampBitirmeProjesi.BLL.Models.UserDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcampBitirmeProjesi.BLL.Validators
{
    public class CreateUserDTOValidator : AbstractValidator<CreateUserDTO>
    {
        public CreateUserDTOValidator()
        {
            RuleFor(a => a.Email).EmailAddress();
            RuleFor(a => a.FirstName).NotEmpty().NotNull().WithMessage("Firstname cannot be empty!");
            RuleFor(a => a.LastName).NotEmpty().NotNull().WithMessage("Lastname cannot be empty!");
            RuleFor(a => a.Apartment.ApartmentNo).NotEmpty().NotNull().WithMessage("Apartment no cannot be empty!");
            RuleFor(a => a.Apartment.Block).NotEmpty().NotNull().WithMessage("Block cannot be empty!");
            RuleFor(a => a.PhoneNumber).NotEmpty().NotNull().WithMessage("Phone number cannot be empty!");
            RuleFor(a => a.PhoneNumber).MaximumLength(10).WithMessage("Phone number must be 10 numbers.").MinimumLength(10).WithMessage("Phone number must be 10 numbers.");
        }
    }
}
