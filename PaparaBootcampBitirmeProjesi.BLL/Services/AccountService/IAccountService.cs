using PaparaBootcampBitirmeProjesi.BLL.Models;
using PaparaBootcampBitirmeProjesi.BLL.Models.AccountDTO;
using System.Threading.Tasks;

namespace PaparaBootcampBitirmeProjesi.BLL.Services.AccountService
{
    public interface IAccountService
    {

        /// <summary>
        /// This can check email and password for login. It returns user or Error message
        /// </summary>
        /// <param name="isLogin"></param>
        /// <returns></returns>
        Task<object> Login(LoginDTO isLogin);


        /// <summary>
        /// If forgot your password it send to new password your email
        /// </summary>
        /// <param name="forgotPassword"></param>
        /// <returns></returns>
        Task<GenericResponse<string>> ForgotPassword(ForgotPasswordDTO forgotPassword);
    }
}
