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
    public class ApartmentRepository : BaseRepository<Apartment>, IApartmentRepository
    {
        private readonly AppDbContext dbContext;
        public ApartmentRepository(AppDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public Apartment ApartmentIsFull(Apartment apartment)
        {
            return table.Where(x => x.ApartmentNo == apartment.ApartmentNo && x.IsFull == false).FirstOrDefault();
        }
    }
}
