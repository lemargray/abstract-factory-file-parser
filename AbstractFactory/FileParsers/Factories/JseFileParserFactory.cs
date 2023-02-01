namespace AbstractFactory;

public class JseFileParserFactory : IFileParserFactory
{
    public IFileParser? NewFileParser(IFileParser.FileType fileType)
    {
        return fileType switch
        {
            IFileParser.FileType.Trade => new JseTradeFileParser(),
            IFileParser.FileType.NonTrade => new JseNonTradeFileParser(),
            _ => null
        };
    }
}