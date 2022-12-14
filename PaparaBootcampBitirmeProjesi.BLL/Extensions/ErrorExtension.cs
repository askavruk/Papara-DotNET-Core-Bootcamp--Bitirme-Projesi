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
        public static string GetValidationErrorMessage(this ValidationResult validationResults)
        {
            string msg = string.Empty;
            foreach (var err in validationResults.Errors)
            {
                msg += $"{err.PropertyName} - {err.ErrorMessage} \n";
            }
            return msg;
        }
    }
}
