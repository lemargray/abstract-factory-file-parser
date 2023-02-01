namespace AbstractFactory;

public class PreliminaryDeal
{
    public IFileParser.FileType FileType { get; set; }
    public string Exchange { get; set; }
    
    public override string ToString()
    {
        return Exchange + " " + FileType.ToString();
    }
}