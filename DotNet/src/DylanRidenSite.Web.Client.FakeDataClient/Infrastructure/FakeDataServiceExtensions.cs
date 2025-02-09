using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DylanRidenSite.Web.Client.FakeDataClient.Infrastructure;

public static class FakeDataServiceExtensions
{
    public static IServiceCollection AddFakeDataClients(this IServiceCollection services,
        IConfiguration configuration)
    {
        return services;
    }
}