using application.contracts;
using context;
using Microsoft.EntityFrameworkCore;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Context = context.Context;

namespace infastructure
{
    public class Repository<TEntity, TId> : IRepository<TEntity, TId>
        where TEntity : class
    {
        protected readonly Context _context;
        private readonly DbSet<TEntity> _dbSet;
        public Repository(Context context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public async Task<TEntity?> GetByIdAsync(TId id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<TEntity> CreateAsync(TEntity item)
        {
            return (await _dbSet.AddAsync(item)).Entity;
        }

        public async Task<TEntity> CreateOnDbAsync(TEntity item)
        {
            var data = await CreateAsync(item);
            await SaveOnDbAsync();
            return data;
        }

        public async Task<bool> DeleteAsync(TId id)
        {
            var item = await GetByIdAsync(id);
            if (item != null)
            {
                _dbSet.Remove(item);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Task<bool> UpdateAsync(TEntity item)
        {
            var entity = _dbSet.Update(item);
            if (entity != null)
            {
                return Task.FromResult(true);
            }
            else
            {
                return Task.FromResult(false);
            }
        }

        public async Task<int> SaveOnDbAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }

  
}
