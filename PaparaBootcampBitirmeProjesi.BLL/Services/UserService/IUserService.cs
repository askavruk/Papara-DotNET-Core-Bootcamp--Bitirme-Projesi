
using PaparaBootcampBitirmeProjesi.BLL.Models.UserDTO;
using System.Collections.Generic;
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

    }
}
