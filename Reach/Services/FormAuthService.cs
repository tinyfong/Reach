using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reach.Core;
using System.Web.Security;

namespace Reach.Services
{
    public class FormAuthService : IFormsAuthentication
    {

        public void SignIn(string userName, bool isPersisient, IEnumerable<string> roles)
        {
            var userData = string.Join(",", roles);

            var authTicket = new FormsAuthenticationTicket(1, userName, DateTime.Now, DateTime.Now.AddDays(30), isPersisient, userData, "/");

            var cookie = new HttpCookie(FormsAuthentication.FormsCookieName, FormsAuthentication.Encrypt(authTicket));

            if (authTicket.IsPersistent)
            {
                cookie.Expires = authTicket.Expiration;
            }

            HttpContext.Current.Response.Cookies.Add(cookie);
        }

        public void SignOut()
        {
            FormsAuthentication.SignOut();
        }
    }
}