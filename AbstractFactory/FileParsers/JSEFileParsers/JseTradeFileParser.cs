namespace AbstractFactory;

public class JseTradeFileParser : IFileParser
{
    public List<PreliminaryDeal> Parse(string file)
    {
        Console.WriteLine("JSE");
        var prelimDeals = new List<PreliminaryDeal>();
        var prelimDeal = new PreliminaryDeal();
        throw new Exception("Error at line 199 and column 7");
        prelimDeal.FileType = IFileParser.FileType.Trade;
        prelimDeals.Add(prelimDeal);

        return prelimDeals;
    }

    public List<PreliminaryDeal>? GetPreliminaryDeals()
    {
        throw new NotImplementedException();
    }
}