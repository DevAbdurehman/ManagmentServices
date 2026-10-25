
using ManagmentServices.Application.Interfaces;
using ManagmentServices.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace ManagmentServices.Infrastructure.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services)
    {
        services.AddScoped<ITaskRepository, TaskRepository>();

        return services;
    }
}
