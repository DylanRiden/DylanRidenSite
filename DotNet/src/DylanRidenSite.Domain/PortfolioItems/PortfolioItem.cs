using DylanRidenSite.Domain.Base;

namespace DylanRidenSite.Domain.PortfolioItems;

public class PortfolioItem:
    IDomainEntity
{
    private PortfolioItem(string title, string shortDescription) { }
    
    public short Id { get; private set; }
    
    public string Title { get; private set; }
    
    public string ShortDescription { get; private set; }
    
    public Uri? WriteUpRef { get; private set; }
    
    public Uri? ImageRef { get; private set; }

    public static PortfolioItem Create(string title, string shortDescription)
        => new(title,
            shortDescription);
    
    public void AddWriteUpRef(Uri url)
    {
        throw new NotImplementedException();
    }

    public void AddImageRef(Uri url)
    {
        throw new NotImplementedException();
    }
    
}