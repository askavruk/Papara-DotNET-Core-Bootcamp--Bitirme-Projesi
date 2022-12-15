using FluentValidation;
using PaparaBootcampBitirmeProjesi.BLL.Models.MessageDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcampBitirmeProjesi.BLL.Validators.MessageValidator
{
    public class CreateMessageDTOValidator : AbstractValidator<CreateMessageDTO>
    {
        public CreateMessageDTOValidator()
        {
            RuleFor(a => a.RecevierMail).EmailAddress().NotEmpty().NotNull().WithMessage("Alıcı maili boş bırakılamaz!");
            RuleFor(a => a.MessageContent).MaximumLength(200).WithMessage("İçeriğiniz en fazla 200 karakterden oluşmalıdır.");


        }
    }
}
 