namespace AbstractFactory;

public class DMATradeFileParser : IFileParser
{
    public List<PreliminaryDeal> Parse(string fileType)
    {
        var prelimDeals = new List<PreliminaryDeal>();
        var prelimDeal = new PreliminaryDeal();
        prelimDeal.FileType = IFileParser.FileType.Trade;
        prelimDeal.Exchange = "DMA";
        prelimDeals.Add(prelimDeal);

        return prelimDeals;
    }
}