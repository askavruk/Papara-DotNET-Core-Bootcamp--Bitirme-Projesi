using AutoMapper;
using Microsoft.AspNetCore.Identity;
using PaparaBootcampBitirmeProjesi.BLL.Models;
using PaparaBootcampBitirmeProjesi.BLL.Models.AccountDTO;
using PaparaBootcampBitirmeProjesi.Core.Entities;
using PaparaBootcampBitirmeProjesi.Core.Enums;
using PaparaBootcampBitirmeProjesi.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcampBitirmeProjesi.BLL.Services.AdminService
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository adminRepository;
        private readonly IMapper mapper;
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;

        public AdminService(IAdminRepository adminRepository, IMapper mapper, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            this.adminRepository = adminRepository;
            this.mapper = mapper;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public async Task CreateUser(CreateUserDTO createUserDTO)
        {
            User user = new User();
            mapper.Map(createUserDTO, user);
            await adminRepository.Create(user);
        }

        public Task DeleteUser(string id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ForgotPassword(ForgotPasswordDTO forgotPassword)
        {
            throw new NotImplementedException();
        }

        public async Task<List<GetUserWithApartmentDTO>> GetAllUsers(string id)
        {
            List<User> users = new List<User>();
            List<GetUserWithApartmentDTO> usersWithApartment = new List<GetUserWithApartmentDTO>();
            users = await adminRepository.GetAll();
            mapper.Map(users, usersWithApartment);

            return usersWithApartment;
        }

        public async Task<UpdateUserDTO> GetById(string id)
        {
            UpdateUserDTO updateUser = new UpdateUserDTO();
            var user = adminRepository.FindUserById(id);
            if (user != null)
            {
                if (user.Status == Status.Active)
                {
                    updateUser = mapper.Map<UpdateUserDTO>(user);
                }
                return updateUser;
            }
            else
            {
                throw new Exception("User not found");
            }
        }


        public Task<object> Login(LoginDTO isLogin)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateUser(UpdateUserDTO model)
        {
            UpdateUserDTO updateUser = new UpdateUserDTO();
            var user = adminRepository.FindUserById(model.Id);
            updateUser = mapper.Map<UpdateUserDTO>(user);
            adminRepository.Update(user);
        }
    }
}
