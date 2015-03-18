using SurveyService.Model.Common;
using SurveyService.Model.Dictionaries;

namespace SurveyService.Model.Entites
{
    public class AttributeEntity : BaseEntity
    {
        public AttributeTypeEntity Type { get; set; }

        public object Value { get; set; }
    }
}
