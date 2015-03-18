using System;

namespace SurveyService.Model.Common
{
    public interface IAuditableEntity : IBaseEntity
    {
        DateTime Created { get; set; }

        DateTime Modified { get; set; }
    }
}
