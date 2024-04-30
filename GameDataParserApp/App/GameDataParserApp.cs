﻿public class GameDataParserApp
{
    private readonly IUserInteractor _userInteractor;
    private readonly IGamesPrinter _gamesPrinter;
    private readonly IVideoGamesDeserializer _videoGamesDeserializer;
    private readonly IFileReader _fileReader;


    public GameDataParserApp(IUserInteractor userInteractor, IGamesPrinter gamesPrinter, IVideoGamesDeserializer videoGamesDeserializer, IFileReader fileReader)
    {
        _userInteractor = userInteractor;
        _gamesPrinter = gamesPrinter;
        _videoGamesDeserializer = videoGamesDeserializer;
        _fileReader = fileReader;
    }

    public void Run()
    {
        string fileName = _userInteractor.ReadFilePath();
        var fileContents = _fileReader.Read(fileName);
        List<VideoGames> videoGames = _videoGamesDeserializer.DeserializeFrom(fileName, fileContents);
        _gamesPrinter.Print(videoGames);
    }

    

    

    
}
