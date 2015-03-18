using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using Survey.Persistance.Validation.Common;
using SurveyService.Model.Entites;

namespace Survey.Persistance.Validation
{
    internal class DealValidator : EntityValidator<ApplicationEntity>
    {
        public override void Validate(DbEntityEntry entityEntry, IDictionary<object, object> items)
        {
            //AddError("Test", "Test message");
        }
    }
}
