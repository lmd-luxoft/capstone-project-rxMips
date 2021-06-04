using Microsoft.Extensions.DependencyInjection;

namespace HomeAccounting.CompositionRoot
{
    public abstract class AbstractApplicationBuilder
    {
        protected readonly IServiceCollection _services;

        protected AbstractApplicationBuilder(IServiceCollection services)
        {
            _services = services;
        }
        
        protected abstract void RegisterBusinessLogic();
        protected abstract void RegisterDataSources();
        protected abstract void RegisterInfrastructure();

        public void Build()
        {
            RegisterInfrastructure();
            RegisterDataSources();
            RegisterBusinessLogic();
        }
    }
}