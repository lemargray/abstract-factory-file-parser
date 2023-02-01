using AbstractFactory;

var exchangeType = "dma";
var fileType = IFileParser.FileType.Trade;
string fileT = "Trade";
IFileParser.FileType type = fileT switch
{
    "Trade" => IFileParser.FileType.Trade,
    "NonTrade" => IFileParser.FileType.NonTrade
};
var filePath = "trade.csv";

List<PreliminaryDeal>? prelimDeals = null;
try
{
    prelimDeals = FileParser.Parse(exchangeType, fileType, filePath);
}
catch (Exception e)
{
    Console.WriteLine(e.Message); // display error to user
}

Console.WriteLine(prelimDeals?[0]);
