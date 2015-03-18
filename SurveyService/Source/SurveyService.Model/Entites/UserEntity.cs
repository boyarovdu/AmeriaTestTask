using System;
using System.Collections.Generic;
using SurveyService.Model.Common;
using SurveyService.Model.Dictionaries;

namespace SurveyService.Model.Entites
{
    public class UserEntity : BaseEntity, IAuditableEntity, IHistoryEntity
    {
        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string PasswordHash { get; set; }

        public RoleEntity Role { get; set; }

        public DateTime Deleted { get; set; }

        public DateTime Created { get; set; }

        public DateTime Modified { get; set; }

        public ICollection<ApplicationEntity> Appications { get; set; }

    }
}
