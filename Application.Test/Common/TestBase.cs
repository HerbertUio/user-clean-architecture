using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserHub.Application.Providers;
using UserHub.Application.Services;
using UserHub.Domain.Repositories;

namespace Application.Test.Common
{
    public class TestBase
    {
        private ServiceProvider _container { get; set; }

        public TestBase()
        {
            var registor = new ServiceCollection();
            registor.AddTransient<IPersonRepository, PersonRepository>();
            registor.AddTransient<IEmailValidatorProvider, EmailValidatorProvider>();
            registor.AddTransient<PersonService>();
            _container = registor.BuildServiceProvider();
        }

        protected TDependency Resolve<TDependency>() where TDependency : notnull
        {
            return _container.GetRequiredService<TDependency>();


        }
    }
}
