using DylanRidenSite.Domain.PortfolioItems;

namespace DylanRidenSite.Web.Client.FakeDataClient.Infrastructure.Services;

public interface IPortfolioItemService
{
    public Task Create(PortfolioItem portfolioItem);
    public Task<IReadOnlyList<PortfolioItem>> GetAll();
    public Task Delete(short id);
}