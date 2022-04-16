using library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.Repositories
{
    public interface IRepository : IDisposable
    {
        public Task<TEntity> Insert<TEntity>(TEntity entity) 
            where TEntity : BaseEntity;
        public Task<TEntity> Get<TEntity>(int id)
            where TEntity : BaseEntity;
        public Task<TEntity> Update<TEntity>(TEntity entity)
            where TEntity : BaseEntity;
        public Task<bool> Delete<TEntity>(int id)
            where TEntity : BaseEntity;
    }
}
