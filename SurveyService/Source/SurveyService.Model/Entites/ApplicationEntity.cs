using System;
using System.Collections.Generic;
using SurveyService.Model.Common;
using SurveyService.Model.Dictionaries;

namespace SurveyService.Model.Entites
{
    public class ApplicationEntity : BaseEntity, IAuditableEntity, IHistoryEntity
    {
        public UserEntity User { get; set; }

        public DateTime Deleted { get; set; }

        public DateTime Created { get; set; }

        public DateTime Modified { get; set; }

        public ApplicationTypeEntity ApplicationType { get; set; }

        public ICollection<AttributeEntity> Attributes { get; set; }
    }
}
