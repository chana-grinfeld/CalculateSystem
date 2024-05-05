using EventsSystemServices.Interfaces;
using EventsSystemServices.Services;
using Microsoft.Extensions.DependencyInjection;

namespace EventsSystemServices
{
    public static class ServiceCollectionExtension
    {
        public static void RegisterServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<ICalculatorService, CalculatorService>();
        }
    }
}