using System.IO;

var userInteractor = new ConsoleUserInteractor();
var application = new GameDataParserApp(userInteractor, new GamesPrinter(userInteractor), new VideoGamesDeserializer(userInteractor), new LocalFileReader());
var _logger = new Logger("logs.txt");
try
{
    application.Run();
}
catch (Exception ex)
{
    Console.WriteLine("Sorry! The application has experienced an unexpected error and will have to be closed.");
    _logger.Log(ex);
}
