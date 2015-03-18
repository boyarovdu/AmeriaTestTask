using System.Collections.Generic;
using SurveyService.Model.Common;

namespace SurveyService.Model.Dictionaries
{
    public class RoleEntity : BaseDictionaryEntity
    {
        public ICollection<PermissionEntity> Permissions { get; set; }
    }
}