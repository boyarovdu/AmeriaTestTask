//using System;
//using System.Diagnostics.Contracts;
//using System.Security.Claims;
//using System.Security.Principal;

//namespace SurveyService.Common.Security
//{
//    public static class SecurityExtensions
//    {
//        public const string DefaultUserIdClaimType = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/userid";

//        public const string FullnameClaimType = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/fullname";

//        public const string PasswordChangeRequiredClaimType = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/passwordchange";

//        public const string PermissionClaimTypePrefix = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/permissions/";

//        public static bool HasPermission(this IPrincipal principal, string permission)
//        {
//            var hasPermission = false;
//            if (principal != null)
//            {
//                var claimsIdentity = principal.Identity as ClaimsIdentity;
//                if (claimsIdentity != null)
//                {
//                    var claimName = ToPermissionClaimName(permission);
//                    hasPermission = claimsIdentity.HasClaim(claimName, bool.TrueString);
//                }
//            }

//            return hasPermission;
//        }

//        public static long UserId(this IIdentity identity)
//        {
//            Contract.Assert(identity != null);

//            var userId = 0L;
//            var claimsIdentity = identity as ClaimsIdentity;
//            if (claimsIdentity != null)
//            {
//                var claim = claimsIdentity.FindFirst(c => c != null && string.Equals(c.Type, DefaultUserIdClaimType, StringComparison.OrdinalIgnoreCase));
//                if (claim != null)
//                {
//                    long.TryParse(claim.Value, out userId);
//                }
//            }

//            return userId;
//        }

//        public static string Fullname(this IIdentity identity)
//        {
//            Contract.Assert(identity != null);

//            string result = null;
//            var claimsIdentity = identity as ClaimsIdentity;
//            if (claimsIdentity != null)
//            {
//                var claim = claimsIdentity.FindFirst(c => c != null && string.Equals(c.Type, FullnameClaimType, StringComparison.OrdinalIgnoreCase));
//                if (claim != null)
//                {
//                    result = claim.Value;
//                }
//            }

//            return result;
//        }

//        public static bool IsPasswordChangeRequired(this IIdentity identity)
//        {
//            Contract.Assert(identity != null);

//            var result = false;
//            var claimsIdentity = identity as ClaimsIdentity;
//            if (claimsIdentity != null)
//            {
//                var claim = claimsIdentity.FindFirst(c => c != null && string.Equals(c.Type, PasswordChangeRequiredClaimType, StringComparison.OrdinalIgnoreCase));
//                result = claim != null;
//            }

//            return result;
//        }

//        public static string ToPermissionClaimName(string value)
//        {
//            return PermissionClaimTypePrefix + value;
//        }
//    }
//}