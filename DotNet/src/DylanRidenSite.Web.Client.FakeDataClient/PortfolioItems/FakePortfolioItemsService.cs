using DylanRidenSite.Domain.PortfolioItems;
using DylanRidenSite.Web.Client.Core.Services;
using Microsoft.AspNetCore.Components;

namespace DylanRidenSite.Web.Client.FakeDataClient.PortfolioItems;

public class FakePortfolioItemsService(NavigationManager navigationManager): IPortfolioItemsService
{
    public Task Create(PortfolioItem portfolioItem)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyList<PortfolioItem>> GetAll()
    {
        return Task.FromResult(FakePortfolioItemData.PortfolioItems(navigationManager.BaseUri));
    }

    public Task Delete(short id)
    {
        throw new NotImplementedException();
    }
}