using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Application
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddPresentation(this IServiceCollection services)
        {
            return services;
        }
    }
}
