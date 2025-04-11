using GameDataParser;
using GameDataParser.IRepository;

var userInteractor = new ConsoleUserInteractor();
var app = new GameDataParserApp(userInteractor);
var logger = new Logger("log.txt");

try
{
    app.Run();
}
catch (Exception ex)
{
    Console.WriteLine("Sorry! The application has experienced an unexceptioned error " +
    "and will have to be closed.");
    logger.Log(ex);
}

Console.WriteLine("Press any key to close.");
Console.ReadKey();



