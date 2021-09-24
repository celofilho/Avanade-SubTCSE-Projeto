using Avanade.SubTCSE.Projeto.Domain.Agreggates;
using Avanade.SubTCSE.Projeto.Domain.Base.Repository;
using Avanade.SubTCSE.Projeto.Domain.Base.Repository.MongoDB;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Data.Repositorys.Base
{
    public abstract class BaseRepository<TEntity, Tid>
        : IBaseRepository<TEntity, Tid> where TEntity : BaseEntity<Tid>
    {
        private readonly IMongoCollection<TEntity> _collection;

        protected BaseRepository(IMongoDBContext mongoDBContext, string collectionName)
        {
            _collection = mongoDBContext.GetCollection<TEntity>(collectionName);
        }

        public virtual async Task<TEntity> AddAsync(TEntity entity)
        {
            await _collection.InsertOneAsync(entity);

            return entity;
        }

        public async Task<List<TEntity>> FindAllAsync()
        {
            var all = await _collection.FindAsync(new BsonDocument());

            return await all.ToListAsync();
        }

        public async Task<TEntity> FindByIdAsync(Tid id)
        {
            var filter = Builders<TEntity>.Filter.Eq("_id", id);

            var resultado = await _collection.FindAsync(filter);

            return resultado.FirstOrDefault();
        }

        public async Task<bool> DeleteByIdAsync(Tid id)
        {
            var deleteFilter = Builders<TEntity>.Filter.Eq("_id", id);
            
            var resultado = await _collection.DeleteOneAsync(deleteFilter);

            if (resultado.DeletedCount.Equals(1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
