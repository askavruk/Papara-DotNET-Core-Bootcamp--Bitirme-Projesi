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
            RuleFor(a => a.FirstName).NotEmpty().NotNull().WithMessage("Lütfen isim girişi yapınız!");
            RuleFor(a => a.LastName).NotEmpty().NotNull().WithMessage("Lütfen soyisim girişi yapınız!");
            RuleFor(a => a.Apartment.ApartmentNo).NotEmpty().NotNull().WithMessage("Lütfen daire no girişi yapınız!");
            RuleFor(a => a.Apartment.Resident).NotEmpty().NotNull().WithMessage("Lütfen daire sakini giriniz!");
            RuleFor(a => a.Apartment.Block).NotEmpty().NotNull().WithMessage("Lütfen bloku giriniz!");
            RuleFor(a => a.Apartment.Type).NotEmpty().NotNull().WithMessage("Lütfen daire tipini giriniz!");
            RuleFor(a => a.Apartment.Floor).NotEmpty().NotNull().WithMessage("Lütfen katı yazınız!");
            RuleFor(a => a.PhoneNumber).NotEmpty().NotNull().WithMessage("Telefon numarası boş bırakılamaz!");
            RuleFor(a => a.PhoneNumber).MaximumLength(10).WithMessage("Telefon numarası 10 haneden oluşmalıdır. Lütfen başında sıfır olmadan giriş yapın").MinimumLength(10).WithMessage("Telefon numarası 10 haneden oluşmalıdır.");
        }
    }
}
