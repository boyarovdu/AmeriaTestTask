using System.Linq;

namespace Survey.Persistance.Common
{
    public interface IRepository<TEntity>
    {
        TEntity GetById(long id);

        void Delete(TEntity entity);

        void Update(TEntity entity);

        void Insert(TEntity entity);

        IQueryable<TEntity> All();
    }
}
