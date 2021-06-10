using HomeAccounting.BusinessLogic;
using HomeAccounting.BusinessLogic.Contracts;
using HomeAccounting.DataSource;
using HomeAccounting.DataSource.Contracts;
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
            _services.AddTransient<IAccounting, AccountingService>();
        }

        protected override void RegisterDataSources()
        {
            _services.AddTransient<IRepository, PostgreRepository>();
        }

        protected override void RegisterInfrastructure()
        {
        }
    }
}