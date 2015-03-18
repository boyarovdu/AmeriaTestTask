using BarterService.DataAccess.Procedures.Projections;
using Survey.Persistance.Common;
using Survey.Persistance.Impl;

namespace SurveyService.Specifications.Procedures
{
    [DbProcedure("users_getdetails")]
    public class SpUsersGetDetails : IStoredProcedure<UserDetailsProjection>
    {
        [DbProcedureParameter("user_id")]
        public long UserId { get; set; }
    }
}
