namespace AbstractFactory;

public class DMANonTradeFileParser : IFileParser
{
    public List<PreliminaryDeal> Parse(string fileType)
    {
        var prelimDeals = new List<PreliminaryDeal>();
        var prelimDeal = new PreliminaryDeal();
        prelimDeal.FileType = IFileParser.FileType.NonTrade;
        prelimDeal.Exchange = "DMA";
        prelimDeals.Add(prelimDeal);

        return prelimDeals;
    }
}