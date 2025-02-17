using DylanRidenSite.Domain.Base;

namespace DylanRidenSite.Domain.PortfolioItems;

public class PortfolioItem:
    IDomainEntity
{
    private PortfolioItem(string title,
        string shortDescription,
        Uri projectLink)
    {
        Title = title;
        ShortDescription = shortDescription;
        ProjectLink = projectLink;
    }
    
    public short Id { get; private set; }

    public string Title { get; private set; } 
    
    public string ShortDescription { get; private set; }
    
    public Uri ProjectLink { get; private set; }
    
    public string? WriteUpMarkdown { get; private set; }
    
    public Uri? ImageRef { get; private set; }

    public static PortfolioItem Create(string title, string shortDescription, Uri projectLink)
        => new(title,
            shortDescription,
            projectLink);

    public static PortfolioItem Create(string title, string shortDescription, Uri projectLink, Uri imageUri)
    {
        var item = PortfolioItem.Create(title, shortDescription, projectLink);
        item.AddImageRef(imageUri);
        return item;
    }

    public void AddImageRef(Uri imageUri)
    {
        this.ImageRef = imageUri;
    }
    
}