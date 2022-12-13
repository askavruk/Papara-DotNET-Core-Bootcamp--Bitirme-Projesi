using PaparaBootcampBitirmeProjesi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcampBitirmeProjesi.Core.IRepositories
{
    public interface IUserRepository : IBaseRepository<User>
    {
        public User FindUserById(string id);
        public List<User> GetAllOnTheABlock();
        public List<User> GetAllOnTheBBlock();
        public List<User> GetAllWithApartment();
    }
}
