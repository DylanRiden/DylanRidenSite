using DylanRidenSite.Domain.PortfolioItems;

namespace DylanRidenSite.Web.Client.FakeDataClient.PortfolioItems;

public static class FakePortfolioItemData
{
    
    public static IReadOnlyList<PortfolioItem> PortfolioItems(string baseUrl) => new List<PortfolioItem>()
    {
        PortfolioItem.Create("FBA Analytics", FbaAnalyticsDescription, new Uri(FbaAnalyticsUrl), new Uri(baseUrl + FbaAnalyticsImagePath)),
        PortfolioItem.Create("Cost Radar", CostRadarDescription, new Uri(CostRadarUrl), new Uri(baseUrl + CostRadarImagePath)),
        PortfolioItem.Create("This Site!", ThisSiteDescription, new Uri(ThisSiteUrl), new Uri(baseUrl + ThisSiteImagePath))
    };

    #region DATA
    
    private const string FbaAnalyticsDescription = 
        "FBA Analytics is my main personal project. It's an Excel add-in designed to provide Amazon sellers with " +
        "tools to search wholesale price lists for profitable products directly within Excel. This addresses the issue " +
        "with existing B2B SaaS solutions where users had to scan price lists on a web app and then transfer the " +
        "data to Excel for further analysis.";

    private const string FbaAnalyticsImagePath 
        = "resources/data/fba-analytics-site.png";

    private const string FbaAnalyticsUrl 
        = "https://fba-analytics.tech";

    private const string CostRadarDescription =
        "lorem ipsum dolor sit amet";
    
    private const string CostRadarImagePath =
        "/resources/data/cost-radar-site.png";
    
    private const string CostRadarUrl 
        = "https://github.com/DylanRiden/InvoiceAutoScan";

    private const string ThisSiteDescription =
        "lorem ipsum dolor sit amet";

    private const string ThisSiteUrl =
        "https://github.com/DylanRiden/DylanRidenSite";
    
    private const string ThisSiteImagePath 
        = "/resources/data/this-site.png";
    
    #endregion

}