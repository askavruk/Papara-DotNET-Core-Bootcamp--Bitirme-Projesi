using PaparaBootcampBitirmeProjesi.Core.Entities;
using PaparaBootcampBitirmeProjesi.Core.IRepositories;
using PaparaBootcampBitirmeProjesi.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcampBitirmeProjesi.DAL.Repositories
{
    public class AdminRepository : BaseRepository<User>, IAdminRepository
    {
        private readonly AppDbContext dbContext;
        public AdminRepository(AppDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public User FindUserById(string id)
        {
            return dbContext.Users.FirstOrDefault(x => x.Id == id);
        }
    }
}
