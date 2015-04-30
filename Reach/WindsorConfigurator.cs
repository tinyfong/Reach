using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reach.Infrastructure;
using Reach.Models;
using Reach.Core;
using Reach.Services;
using System.Web.Security;
using Reach.Mappers;
using Reach.DTO;

namespace Reach
{
    public class WindsorConfigurator
    {
        public static void Configure()
        {
            WindsorRegistrar.Register<IUserService, UserService>();
            WindsorRegistrar.Register<IFormsAuthentication, FormAuthService>();
            WindsorRegistrar.Register<ICrudService<Video>, VideoService>();
            WindsorRegistrar.Register<IMapper<Video, YoukuVideoInput>, VideoMapper>();

            WindsorRegistrar.registerAllFromAssemblies("Reach");

        }
    }
}