using Avanade.SubTCSE.Projeto.Domain.Agreggates;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Domain.Base.Repository
{
    public interface IBaseRepository<TEntity, TId>
        where TEntity : BaseEntity<TId>
    {
        Task<TEntity> Add(TEntity entity);

        Task<TEntity> FindById(TId id);

    }
}
