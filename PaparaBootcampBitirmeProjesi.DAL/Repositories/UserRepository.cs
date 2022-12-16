using Microsoft.EntityFrameworkCore;
using PaparaBootcampBitirmeProjesi.Core.Entities;
using PaparaBootcampBitirmeProjesi.Core.Enums;
using PaparaBootcampBitirmeProjesi.Core.IRepositories;
using PaparaBootcampBitirmeProjesi.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcampBitirmeProjesi.DAL.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly AppDbContext dbContext;
        public UserRepository(AppDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public User FindUserById(string id)
        {
            return dbContext.Users.Include(x => x.Apartment).FirstOrDefault(x => x.Id == id);
        }

        public List<User> GetAllOnTheABlock()
        {
            return table.Where(x => x.Status == Status.Active && x.Apartment.Block == Block.A).Include(x => x.Apartment).Include(x => x.Vehicle).ToList();
        }

        public List<User> GetAllOnTheBBlock()
        {
            return table.Where(x => x.Status == Status.Active && x.Apartment.Block == Block.B).Include(x => x.Apartment).Include(x => x.Vehicle).ToList();
        }

        public List<User> GetAllWithApartment()
        {
            return dbContext.Users.Where(x => x.Status == Status.Active).Include(a => a.Apartment).Include(a => a.Vehicle).ToList();
        }
    }
}
