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
    public class BaseRepository<T> : IBaseRepository<T> where T : class, IBaseEntity
    {
        private readonly AppDbContext dbContext;
        protected DbSet<T> table;

        public BaseRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
            table= dbContext.Set<T>();
        }

        /// <summary>
        /// Adds the entity to the table and updates it in the database.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task Create(T entity)
        {
            table.Add(entity);
            await dbContext.SaveChangesAsync();
        }


        /// <summary>
        /// Passive the Status of the entity and updates the DeleteDate.
        /// </summary>
        /// <param name="entity"></param>
        public void Delete(T entity)
        {
            entity.DeleteDate = DateTime.Now;
            entity.Status = Status.Passive;
            dbContext.SaveChanges();
        }

        /// <summary>
        /// Lists all entities with Active Status
        /// </summary>
        /// <returns></returns>
        public async Task<List<T>> GetAll()
        {
            return await table.Where(x => x.Status == Status.Active).ToListAsync(); 
        }


        /// <summary>
        /// Modifies the entity's Status and updates the Entity.
        /// </summary>
        /// <param name="entity"></param>
        public void Update(T entity)
        {
            dbContext.Entry<T>(entity).State = EntityState.Modified;
            dbContext.SaveChanges();
        }
    }
}
