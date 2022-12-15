using PaparaBootcampBitirmeProjesi.BLL.Models;
using PaparaBootcampBitirmeProjesi.BLL.Models.AccountDTO;
using PaparaBootcampBitirmeProjesi.BLL.Models.UserDTO;
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
        List<GetUsersWithApartmentDTO> GetAllUsers();

        /// <summary>
        /// It calss all user by A block
        /// </summary>
        /// <param name="block"></param>
        /// <returns></returns>
        List<GetUsersWithApartmentDTO> GetAllUsersOnTheABlock();

        /// <summary>
        /// It calss all user by B block
        /// </summary>
        /// <param name="block"></param>
        /// <returns></returns>
        List<GetUsersWithApartmentDTO> GetAllUsersOnTheBBlock();

        Task DeleteUser(string id);

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
