using System;

namespace SurveyService.Model.Common
{
    public interface IHistoryEntity : IBaseEntity
    {
        DateTime Deleted { get; set; }
    }
}
