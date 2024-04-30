public interface IVideoGamesDeserializer
{
    List<VideoGames> DeserializeFrom(string fileName, string fileContents);
}
