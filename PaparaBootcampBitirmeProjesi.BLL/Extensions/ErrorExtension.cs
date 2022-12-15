using FluentValidation.Results;
using PaparaBootcampBitirmeProjesi.BLL.Models.UserDTO;
using PaparaBootcampBitirmeProjesi.BLL.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcampBitirmeProjesi.BLL.Extensions
{
    public static class ErrorExtension
    {
        public static List<string> GetValidationErrorMessage(this List<ValidationFailure> failures)
        {
            List<string> response = new(); 
            
            foreach (var err in failures)
            {
                response.Add($"{err.PropertyName} - {err.ErrorMessage} \n");
            }
            return response;
        }
    }
}
