using AbstractFactory;

var exchangeType = "jse";
var fileType = IFileParser.FileType.Trade;
var filePath = "trade.csv";

// var exchange = FileParserFactoryProducer.NewFileParserFactory(exchangeType);
// var parser = exchange?.NewFileParser(fileType);
// var prelimDeals = parser?.Parse(filePath);

var prelimDeals = FileParser.Parse(exchangeType, fileType, filePath);


Console.WriteLine(prelimDeals?[0]);
