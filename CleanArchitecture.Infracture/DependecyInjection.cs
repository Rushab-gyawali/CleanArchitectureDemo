using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Application
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddInfracture(this IServiceCollection services)
        {
            return services;
        }
    }
}
