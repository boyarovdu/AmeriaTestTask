using SurveyService.Model.Common;

namespace SurveyService.Model.Dictionaries
{
    public class PermissionEntity : BaseDictionaryEntity
    {
        public RoleEntity Role { get; set; }
    }
}
