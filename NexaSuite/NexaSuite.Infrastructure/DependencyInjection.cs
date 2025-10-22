using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NexaSuite.Application.Contracts.Repositories;
using NexaSuite.Infrastructure.Repositories;

namespace NexaSuite.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        // Register repositories
        services.AddSingleton<IUserRepository, InMemoryUserRepository>();

        return services;
    }
}
