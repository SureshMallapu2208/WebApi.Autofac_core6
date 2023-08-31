using Autofac;
using System.Reflection.Metadata;
using WebApi.Autofac.Services;
using WebApi.Autofac.Services.Impl;

namespace WebApi.Autofac
{
    public sealed class AutofacModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {


            // Transient
            //builder.RegisterType<Implementation_Class>().As<ISample>()
            //    .InstancePerDependency();


            //// Scoped
            builder.RegisterType<Implementation_Class>().As<ISample>()
                .InstancePerLifetimeScope();

            //// Singleton
            //builder.RegisterType<Implementation_Class>().As<ISample>()
            //    .SingleInstance();



        }
    }
}
