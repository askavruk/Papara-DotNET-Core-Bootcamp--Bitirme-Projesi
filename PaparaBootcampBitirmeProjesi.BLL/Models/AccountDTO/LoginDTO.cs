using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcampBitirmeProjesi.BLL.Models.AccountDTO
{
    public class LoginDTO
    {
        [Required(ErrorMessage = "Lütfen email adresinizi girin...")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi girin...")]
        public string Password { get; set; }
    }
}
