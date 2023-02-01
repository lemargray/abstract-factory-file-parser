namespace AbstractFactory;

public class JseNonTradeFileParser : IFileParser
{
    public List<PreliminaryDeal> Parse(string file)
    {
        Console.WriteLine("JSE is parsing a file");
        var prelimDeals = new List<PreliminaryDeal>();
        var prelimDeal = new PreliminaryDeal();
        prelimDeal.FileType = IFileParser.FileType.NonTrade;
        prelimDeals.Add(prelimDeal);

        return prelimDeals;
    }

    public List<PreliminaryDeal>? GetPreliminaryDeals()
    {
        throw new NotImplementedException();
    }
}