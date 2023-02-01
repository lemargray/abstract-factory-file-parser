namespace AbstractFactory;

public class DMAFileParserFactory : IFileParserFactory
{
    public IFileParser? NewFileParser(IFileParser.FileType fileType)
    {
        if (fileType == IFileParser.FileType.Trade)
        {
            return new DMATradeFileParser();
        } else if (fileType == IFileParser.FileType.NonTrade)
        {
            return new DMANonTradeFileParser();
        }

        return null;
    }
}