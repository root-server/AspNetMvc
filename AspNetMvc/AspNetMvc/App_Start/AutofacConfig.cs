using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using DependencyInjection.Interfaces;
using DependencyInjection.Models;

namespace AspNetMvc.App_Start
{
    public class AutofacConfig
    {
        public static void Register(/*HttpConfiguration config*/)
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers().PropertiesAutowired();
            builder.RegisterType<Bazuka>();
            builder.RegisterType<Warrior>();
            builder.Register<IWeapon>(x => x.Resolve<Bazuka>());
            //builder.RegisterWebApiFilterProvider(config);
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            //config.DependencyResolver = new AutofacDependencyResolver(container);
        }
    }
}
