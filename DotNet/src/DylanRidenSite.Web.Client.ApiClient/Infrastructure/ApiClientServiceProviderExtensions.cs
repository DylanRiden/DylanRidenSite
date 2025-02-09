using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DylanRidenSite.Web.Client.ApiClient.Infrastructure;

public static class ApiClientServiceProviderExtensions
{
    public static IServiceCollection AddApiClient(this IServiceCollection services,
        IConfiguration configuration)
    {
        //TODO: Add API Client Services
        return services;
    }
}