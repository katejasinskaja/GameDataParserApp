public class GamesPrinter : IGamesPrinter
{
    public readonly IUserInteractor _userInteractor;

    public GamesPrinter(IUserInteractor userInteractor)
    {
        _userInteractor = userInteractor;
    }

    public void Print(List<VideoGames> videoGames)
    {
        if (videoGames.Count > 0)
        {
            _userInteractor.ShowMessage("Loaded games are:");
            foreach (var videoGame in videoGames)
            {
                _userInteractor.ShowMessage(videoGame.ToString());
            }
        }
        else
        {
            _userInteractor.ShowMessage("No games are present in the input file.");
        }
    }
}
