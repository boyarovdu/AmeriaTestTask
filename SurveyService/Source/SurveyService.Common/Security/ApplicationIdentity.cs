//using System.Collections.Generic;
//using System.Globalization;
//using System.Security.Claims;

//namespace SurveyService.Common.Security
//{
//    public class ApplicationIdentity : ClaimsIdentity
//    {
//        public static readonly ApplicationIdentity Anonymous = new ApplicationIdentity(0, string.Empty, string.Empty, false, null, null);

//        public ApplicationIdentity(long userId, string name, string fullname, bool shouldChangePassword, IEnumerable<string> permissions, string authenticationType)
//            : this(new[] { new Claim(SecurityExtensions.DefaultUserIdClaimType, userId.ToString(CultureInfo.InvariantCulture)) }, authenticationType)
//        {
//            // ReSharper disable DoNotCallOverridableMethodsInConstructor
//            if (shouldChangePassword)
//            {
//                AddClaim(new Claim(SecurityExtensions.PasswordChangeRequiredClaimType, bool.TrueString));
//            }

//            if (permissions != null)
//            {
//                foreach (var p in permissions)
//                {
//                    var permissionClaimName = SecurityExtensions.ToPermissionClaimName(p);
//                    AddClaim(new Claim(permissionClaimName, bool.TrueString));
//                }
//            }
//        }

//        private ApplicationIdentity(IEnumerable<Claim> claims, string authenticationType)
//            : base(claims, authenticationType, DefaultNameClaimType, DefaultRoleClaimType)
//        {
//        }

//        public new ApplicationIdentity Clone()
//        {
//            return new ApplicationIdentity(Claims, AuthenticationType);
//        }
//    }
//}