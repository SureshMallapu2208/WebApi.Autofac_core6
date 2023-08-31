using Autofac;
using WebApi.Autofac.Services;
using WebApi.Autofac.Services.Impl;

namespace WebApi.Autofac
{
    public sealed class AutofacModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Implementation_Class>().As<ISample>().SingleInstance();


            // Transient
            //builder.RegisterType<Implementation_Class>().As<ISample>()
            //    .InstancePerDependency();


            //// Scoped
            //builder.RegisterType<Implementation_Class>().As<ISample>()
            //    .InstancePerLifetimeScope();

            //// Singleton
            //builder.RegisterType<Implementation_Class>().As<ISample>()
            //    .SingleInstance();

            // Scan an assembly for components
            //builder.RegisterAssemblyTypes(typeof(AssemblyReference).Assembly)
            //       .Where(t => t.Name.EndsWith("Implementation"))
            //       .AsImplementedInterfaces();

        }
    }
}
