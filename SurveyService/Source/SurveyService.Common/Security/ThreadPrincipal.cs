//using System.Security.Claims;
//using System.Security.Principal;
//using System.Threading;

//namespace SurveyService.Common.Security
//{
//    public class ThreadPrincipal : IPrincipal
//    {
//        #region Properties

//        public IIdentity Identity
//        {
//            get
//            {
//                return CurrentPrincipal.Identity;
//            }
//        }

//        private static IPrincipal CurrentPrincipal
//        {
//            get
//            {
//                var principal = Thread.CurrentPrincipal;
//                return principal ?? new ClaimsPrincipal();
//            }
//        }

//        #endregion

//        #region Public Methods and Operators

//        public bool IsInRole(string role)
//        {
//            return CurrentPrincipal.IsInRole(role);
//        }

//        #endregion
//    }
//}