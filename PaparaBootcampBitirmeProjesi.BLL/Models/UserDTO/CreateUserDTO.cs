using PaparaBootcampBitirmeProjesi.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcampBitirmeProjesi.BLL.Models.UserDTO
{
    public class CreateUserDTO
    {
        [Required(ErrorMessage = "İsim alanı zorunludur...")]
        public string FirstName { get; set; }
        public string SecondName { get; set; }

        [Required(ErrorMessage = "Soyisim alanı zorunludur...")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Tc Kimlik numarası zorunludur...")]
        public string IdentityNumber { get; set; }

        [Required(ErrorMessage = "Email alanı zorunludur...")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telefon alanı zorunludur...")]
        public string PhoneNumber { get; set; }
        public Apartment Apartment { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
