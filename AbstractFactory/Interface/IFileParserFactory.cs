namespace AbstractFactory;

public interface IFileParserFactory
{
    public IFileParser? NewFileParser(IFileParser.FileType fileType);
}