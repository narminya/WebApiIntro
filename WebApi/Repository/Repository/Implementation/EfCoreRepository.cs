using Domain.Base;
using Microsoft.EntityFrameworkCore;
using Repository.DataAccessLayer;
using Repository.Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository.Implementation
{
   public class EfCoreRepository<T> : IRepository<T> where T : class, IEntity
    {
        protected readonly AppDbContext Db;
        public EfCoreRepository(AppDbContext db)
        {
            Db = db;
        }
        public async Task<IList<T>> GetAllAsync()
        {
            return await Db.Set<T>().ToListAsync();
        }

        public async Task<T> GetAsync(int id)
        {
            return await Db.Set<T>().FindAsync(id);
        }
        public Task<bool> AddAsync(T item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AddAsync(List<T> items)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AddAsync(params T[] items)
        {
            throw new NotImplementedException();
        }

        public bool Update(T item)
        {
            throw new NotImplementedException();
        }

        public bool Update(List<T> items)
        {
            throw new NotImplementedException();
        }

        public bool Update(params T[] items)
        {
            throw new NotImplementedException();
        }
        public Task<bool> DeleteAsync(T item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(List<T> items)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(params T[] items)
        {
            throw new NotImplementedException();
        }

  

    }
}
