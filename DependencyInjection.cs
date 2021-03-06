using LeapYears.Interfaces;
using LeapYears.Repositories;
using LeapYears.Services;
using Microsoft.Extensions.DependencyInjection;

namespace LeapYears
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddHistoryService (this IServiceCollection services)
        {
            services.AddTransient<IHistoryService, HistoryService>();
            services.AddTransient<IHistoryRepository, HistoryRepository>();

            return services;
        }

        public static IServiceCollection AddPersonService (this IServiceCollection services)
        {
            services.AddTransient<IPersonService, PersonService>();
            services.AddTransient<IPersonRepository, PersonRepository>();

            return services;
        }
    }
}
