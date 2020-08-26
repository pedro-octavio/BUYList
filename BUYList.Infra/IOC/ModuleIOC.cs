using Autofac;

namespace BUYList.Infra.IOC
{
    public class ModuleIOC :
    Module
    {
        protected override void Load
        (ContainerBuilder builder) => ConfigurationIOC.Load(builder);
    }
}
