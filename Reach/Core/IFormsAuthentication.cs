using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Reach.Core
{
    public interface IFormsAuthentication
    {
        void SignIn(string userName, bool isPersisient, IEnumerable<string> roles);
        void SignOut();
    }
}