using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.contracts
{
    public interface IRepository<TEntity, TId>
        where TEntity : class
    {
        Task<TEntity?> GetByIdAsync(TId id);
        Task<TEntity> CreateAsync(TEntity item);

        Task<TEntity> CreateOnDbAsync(TEntity item);

        Task<bool> UpdateAsync(TEntity item);
        Task<bool> DeleteAsync(TId id);
        Task<int> SaveOnDbAsync();
    }
}
