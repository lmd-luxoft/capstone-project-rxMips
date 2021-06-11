using HomeAccounting.BusinessLogic.Contracts;
using HomeAccounting.DataSource;
using HomeAccounting.DataSource.Contracts;
using HomeAccounting.DataSource.EF.Application;
using Microsoft.Extensions.DependencyInjection;
using AccountingServiceOld = HomeAccounting.BusinessLogic.AccountingService;

namespace HomeAccounting.CompositionRoot
{
    public class AspNetApplicationBuilder : AbstractApplicationBuilder
    {
        public AspNetApplicationBuilder(IServiceCollection services) : base(services)
        {
        }

        protected override void RegisterBusinessLogic()
        {
            _services.AddTransient<IAccounting, AccountingServiceOld>();
        }

        protected override void RegisterDataSources()
        {
            _services.AddTransient<IRepository, PostgreRepository>();
            _services.AddDbContext<DomainContext>();
        }

        protected override void RegisterInfrastructure()
        {
        }
    }
}