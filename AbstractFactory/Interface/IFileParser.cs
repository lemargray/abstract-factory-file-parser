namespace AbstractFactory;

public interface IFileParser
{
    public enum FileType
    {
        Trade,
        NonTrade
    };
    public List<PreliminaryDeal> Parse(string fileType);
}