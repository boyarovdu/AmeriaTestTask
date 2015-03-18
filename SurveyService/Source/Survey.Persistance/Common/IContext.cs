using System.Data.Entity;
using SurveyService.Model.Common;

namespace Survey.Persistance.Common
{
    public interface IContext
    {
        void Save();

        IDbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity;

        Database Database { get; }
    }
}
