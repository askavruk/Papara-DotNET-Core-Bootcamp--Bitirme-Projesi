using PaparaBootcampBitirmeProjesi.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcampBitirmeProjesi.BLL.Models.UserDTO
{
    public class UpdateUserDTO
    {
        public string Id { get; set; }

        [Required(ErrorMessage = "İsim alanı boş bırakılamaz...")]
        public string FirstName { get; set; }
        public string SecondName { get; set; }

        [Required(ErrorMessage = "Soyisim alanı boş bırakılamaz...")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email alanı boş bırakılamaz...")]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Apartment Apartment { get; set; }
        public Vehicle Vehicle { get; set; }

    }
}
