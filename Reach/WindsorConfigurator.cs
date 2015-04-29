using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reach.Infrastructure;
using Reach.Models;
using Reach.Core;
using Reach.Services;
using System.Web.Security;

namespace Reach
{
    public class WindsorConfigurator
    {
        public static void Configure()
        {
            WindsorRegistrar.Register<IUserService, UserService>();
            WindsorRegistrar.Register<IFormsAuthentication, FormAuthService>();
            WindsorRegistrar.Register<ICrudService<Video>, VideoService>();

            WindsorRegistrar.registerAllFromAssemblies("Reach");

        }
    }
}