using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebFinancesAccounting.Models.Repositories.EF;
using WebFinancesAccounting.Models.Repositories.Interfaces;

namespace WebFinancesAccounting.Util
{
    public class MyModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IRepository>().To<Repository>();
        }
    }
}