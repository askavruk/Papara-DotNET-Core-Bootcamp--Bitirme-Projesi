using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcampBitirmeProjesi.BLL.Models.AccountDTO
{
    public class ForgotPasswordDTO
    {
        [Required(ErrorMessage = "Lütfen email adresinizi girin...")]
        public string Email { get; set; }

    }
}
