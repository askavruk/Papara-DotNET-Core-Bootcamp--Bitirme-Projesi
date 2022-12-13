using PaparaBootcampBitirmeProjesi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcampBitirmeProjesi.Core.IRepositories
{
    public interface IBaseRepository<T> where T : IBaseEntity
    {
        Task Create(T entity);
        Task<List<T>> GetAll();
    }
}

