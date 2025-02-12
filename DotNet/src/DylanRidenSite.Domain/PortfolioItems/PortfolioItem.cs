using DylanRidenSite.Domain.Base;

namespace DylanRidenSite.Domain.PortfolioItems;

public class PortfolioItem:
    IDomainEntity
{
    public int Id { get; private set; }
    
    public string Name { get; private set; }
    
    public string ShortDescription { get; private set; }
    
    public Uri ImageUri { get; private set; }
}