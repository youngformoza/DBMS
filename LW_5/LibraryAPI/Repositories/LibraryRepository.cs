using AutoMapper;
using LibraryAPI.ApplicationContexts;
using LibraryAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAPI.Repositories
{
    public class LibraryRepository<TContext> : IRepository<TContext>, IDisposable where TContext : DbContext
    {
        private readonly DbLibraryContext _context;
        private bool disposed = false;
        private readonly IMapper _mapper;

        public LibraryRepository(DbLibraryContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> DeleteAsync<TEntity>(int id) where TEntity : BaseEntity
        {
            var entity = await _context.Set<TEntity>().FirstAsync(a => a.Id == id);

            if (entity == null)
            {
                return false;
            }

            _context.Set<TEntity>().Remove(entity);
            await Save();
            return true;
        }

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

        public async Task<TEntity> GetAsync<TEntity>(int id) where TEntity : BaseEntity
        {
            return await _context.Set<TEntity>().FirstAsync(a => a.Id == id);
        }

        public async Task<List<TEntity>> GetAllAsync<TEntity>() where TEntity : BaseEntity
        {
            return await _context.Set<TEntity>().AsNoTracking().ToListAsync();
        }


        public async Task<int> InsertAsync<TEntity>(TEntity entity) where TEntity : BaseEntity
        {
            await _context.Set<TEntity>().AddAsync(entity);
            await Save();
            return entity.Id;
        }

        public async Task<bool> UpdateAsync<TEntity>(TEntity newEntity) where TEntity : BaseEntity
        {
            var entity = await _context.Set<TEntity>().Where(i => i.Id == newEntity.Id).FirstAsync();
            _mapper.Map(newEntity, entity);

            await Save();

            return true;
        }
    }
}
