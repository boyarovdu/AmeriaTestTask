namespace SurveyService.Model.Common
{
    public class BaseDictionaryEntity : BaseEntity, IDictionaryEntity
    {
        public string Name { get; set; }
    }
}
