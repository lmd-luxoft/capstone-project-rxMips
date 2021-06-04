using Microsoft.Extensions.DependencyInjection;

namespace HomeAccounting.CompositionRoot
{
    public class AspNetApplicationBuilder: AbstractApplicationBuilder
    {
        public AspNetApplicationBuilder(IServiceCollection services) : base(services)
        {
        }

        protected override void RegisterBusinessLogic()
        {
            throw new System.NotImplementedException();
        }

        protected override void RegisterDataSources()
        {
            throw new System.NotImplementedException();
        }

        protected override void RegisterInfrastructure()
        {
            throw new System.NotImplementedException();
        }
    }
}