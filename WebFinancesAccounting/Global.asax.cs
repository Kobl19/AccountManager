using Ninject;
using Ninject.Modules;
using Ninject.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using WebFinancesAccounting.Util;

namespace WebFinancesAccounting
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            NinjectModule Module = new MyModule();
            var kernel = new StandardKernel(Module);
            DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));
        }
    }
}
