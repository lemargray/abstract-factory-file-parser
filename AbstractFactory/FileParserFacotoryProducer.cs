namespace AbstractFactory;

public static class FileParserFactoryProducer
{
    public static IFileParserFactory? NewFileParserFactory(string exchange)
    {
        return exchange switch
        {
            "jse" => new JseFileParserFactory(),
            "dma" => new DMAFileParserFactory(),
            _ => null
        };
    }
}