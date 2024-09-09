using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Application
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var assembly = typeof(DependecyInjection).Assembly;
            services.AddMediatR(configuration =>
            configuration.RegisterServicesFromAssembly(
                typeof(DependecyInjection).Assembly));

            services.AddValidatorsFromAssembly(assembly);

            return services;
        }
    }
}
