using Avanade.SubTCSE.Projeto.Domain.Agreggates;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Domain.Base.Repository
{
    public interface IBaseRepository<TEntity, TId>
        where TEntity : BaseEntity<TId>
    {
        Task<TEntity> AddAsync(TEntity entity);

        Task<TEntity> FindByIdAsync(TId id);

        Task<List<TEntity>> FindAllAsync();

        Task<bool> DeleteByIdAsync(TId id);

    }
}
