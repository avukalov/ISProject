using Autofac;
using ISProject.Service.Common;

namespace ISProject.Service
{
    public class ServiceDIModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterType<ApiResourceService>().As<IApiResourceService>().InstancePerLifetimeScope();
            builder.RegisterType<ApiScopeService>().As<IApiScopeService>().InstancePerLifetimeScope();
            
        }
    }
}
