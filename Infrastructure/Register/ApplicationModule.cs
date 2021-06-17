using Autofac;
using Web.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Api.Infrastructure.Register
{
    public class ApplicationModule
       : Autofac.Module
    {

        public string QueriesConnectionString { get; }

        public ApplicationModule(string qconstr)
        {
            QueriesConnectionString = qconstr;

        }

        protected override void Load(ContainerBuilder builder)
        {


             


            //builder.RegisterType<CovidCaseQueries>().As<ICovidCaseQueries>().InstancePerLifetimeScope();

            //builder.RegisterType<CovidCaseRepository>()
            //   .As<ICovidCaseRepository>().InstancePerLifetimeScope();

          
            
        }
    }
}
