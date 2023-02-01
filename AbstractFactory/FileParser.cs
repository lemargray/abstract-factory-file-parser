namespace AbstractFactory;

public class FileParser
{
    public static List<PreliminaryDeal>? Parse(string exchange, IFileParser.FileType fileType, string filePath)
    {
        var parser = FileParserFactoryProducer.NewFileParserFactory(exchange)?.NewFileParser(fileType);
        return parser?.Parse(filePath);
    }
}