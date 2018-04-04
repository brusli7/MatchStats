using System;
using Autofac;
using Autofac.Integration.WebApi;
using System.Web.Http;
using System.Reflection;
using MatchStatsCore.Models;
using MatchStatsServer.Controllers;
using MatchStatsServer.API;
using MatchStatsCore.Data;

namespace MatchStatsServer.App_Start
{
    public class IoCConfig
    {
        public static void RegisterDependencies()
        {
            var builder = new ContainerBuilder();

            var config = GlobalConfiguration.Configuration;
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            // Business Objects

            // Data Access Objects









           
            builder.RegisterType<TournamentTypeDA>().As<ITournamentTypeDA>().InstancePerRequest();

















            //builder.RegisterType<SkillDA>().As<ISkillDA>().InstancePerRequest();


            // Helpers


            // Register controllers

            builder.RegisterType<HomeController>().InstancePerRequest();
            builder.RegisterType<TournamentController>().InstancePerRequest();
            builder.RegisterWebApiFilterProvider(config);
            builder.RegisterWebApiModelBinderProvider();




            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);



            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
        }
    }
}