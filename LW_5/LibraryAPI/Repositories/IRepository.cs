using LibraryAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAPI.Repositories
{
    public interface IRepository<TContext> where TContext : DbContext
    {
        public Task<int> InsertAsync<TEntity>(TEntity entity) 
            where TEntity : BaseEntity;
        public Task<TEntity> GetAsync<TEntity>(int id)
            where TEntity : BaseEntity;
        public Task<List<TEntity>> GetAllAsync<TEntity>()
            where TEntity : BaseEntity;

        public Task<bool> UpdateAsync<TEntity>(TEntity entity)
            where TEntity : BaseEntity;
        public Task<bool> DeleteAsync<TEntity>(int id)
            where TEntity : BaseEntity;
    }
}
