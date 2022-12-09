using PaparaBootcampBitirmeProjesi.BLL.Models;
using PaparaBootcampBitirmeProjesi.BLL.Models.AccountDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcampBitirmeProjesi.BLL.Services.AdminService
{
    public interface IUserService
    {

        Task CreateUser(CreateUserDTO createUserDTO);

        /// <summary>
        /// According to id parameter, it returns UpdateUserDTO
        /// </summary>
        /// <param name="id"></param>
        /// <returns>UpdateUserDTO</returns>
        Task<UpdateUserDTO> GetById(string id);

        /// <summary>
        /// It is update according to model parameter(UpdateUserDTO)
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task UpdateUser(UpdateUserDTO model);

        /// <summary>
        /// It calls all users with their apartment
        /// </summary>
        /// <returns></returns>
        Task<List<GetUserWithApartmentDTO>> GetAllUsers();
        List<GetUserWithApartmentDTO> GetAllUsersOnTheBlock(string block);

        Task DeleteUser(string id);

        /// <summary>
        /// This can check email and password for login. It returns user or Error message
        /// </summary>
        /// <param name="isLogin"></param>
        /// <returns></returns>
        Task<object> Login(LoginDTO isLogin);

        Task<bool> ForgotPassword(ForgotPasswordDTO forgotPassword);
    }
}
