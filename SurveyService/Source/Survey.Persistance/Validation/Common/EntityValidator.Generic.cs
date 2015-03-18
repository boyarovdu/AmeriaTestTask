using SurveyService.Model.Common;

namespace Survey.Persistance.Validation.Common
{
    internal abstract class EntityValidator<TEntity> : EntityValidator
        where TEntity : BaseEntity
    {
    }
}
