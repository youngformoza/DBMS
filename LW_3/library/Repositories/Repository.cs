﻿using library.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.Repositories
{
    public class Repository : IRepository
    {
        private readonly db_libraryContext _context;
        private bool disposed = false;

        public Repository(db_libraryContext context)
        {
            _context = context;
        }

        public async Task<bool> Delete<TEntity>(int id) where TEntity : BaseEntity
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

        public async Task<TEntity> Get<TEntity>(int id) where TEntity : BaseEntity
        {
            return await _context.Set<TEntity>().FirstAsync(a => a.Id == id); 
        }

        public async Task<TEntity> Insert<TEntity>(TEntity entity) where TEntity : BaseEntity
        {
            await _context.Set<TEntity>().AddAsync(entity);
            await Save();
            return entity;
        }

        public async Task<TEntity> Update<TEntity>(TEntity entity) where TEntity : BaseEntity
        {
            var upd_entity = await _context.Set<TEntity>().FirstAsync(a => a.Id == entity.Id);

            if (upd_entity == null)
            {
                return null;
            }

            _context.Set<TEntity>().Update(upd_entity);
            upd_entity = entity;

            await Save();
            return upd_entity;
        }
    }
}
