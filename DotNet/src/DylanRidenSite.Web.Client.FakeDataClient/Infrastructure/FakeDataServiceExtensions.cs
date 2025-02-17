using DylanRidenSite.Web.Client.Core.Services;
using DylanRidenSite.Web.Client.FakeDataClient.PortfolioItems;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DylanRidenSite.Web.Client.FakeDataClient.Infrastructure;

public static class FakeDataServiceExtensions
{
    public static IServiceCollection AddFakeDataClients(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddScoped<IPortfolioItemsService, FakePortfolioItemsService>();
        return services;
    }
}