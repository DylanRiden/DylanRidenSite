using DylanRidenSite.Domain.PortfolioItems;

namespace DylanRidenSite.Web.Client.Core.Services;

public interface IPortfolioItemsService
{
    public Task Create(PortfolioItem portfolioItem);
    public Task<IReadOnlyList<PortfolioItem>> GetAll();
    public Task Delete(short id);
}