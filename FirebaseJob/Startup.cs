using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using FirebaseJob.Extensions;
using FirebaseJob.Managers;
using FirebaseJob.Services;

[assembly: FunctionsStartup(typeof(FirebaseJob.Startup))]

namespace FirebaseJob
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddFirebaseClient();
            builder.Services.AddScoped(typeof(IManager<>), typeof(Manager<>));
            builder.Services.AddTransient<ICustomerPurchaseManager, CustomerPurchaseManager>();
        }
    }
}