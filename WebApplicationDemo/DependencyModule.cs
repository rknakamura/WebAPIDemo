using System;
using Ninject.Modules;

namespace WebApplicationDemo
{
    public class DependencyModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IDependencyInjection>().To<DependencyInjection>();
        }
    }
}