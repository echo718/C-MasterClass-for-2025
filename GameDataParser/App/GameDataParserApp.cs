using System.Text.Json;
using GameDataParser.IRepository;
using GameDataParser.Repository;

namespace GameDataParser
{
    public class GameDataParserApp
    {
        private readonly IuserInteractor _userInteractor;

        public GameDataParserApp(IuserInteractor userInteractor)
        {
            _userInteractor = userInteractor;
        }

        public void Run()
        {
            string fileName = _userInteractor.ReadValidFilePath();
            var fileContents = File.ReadAllText(fileName);
            var videoGames = DeserializeVideoGamesFrom(fileName, fileContents);
            //GamesPrinter(videoGames);
        }

        private List<VideoGame> DeserializeVideoGamesFrom(string fileName, string fileContents)
        {
            try
            {
                return JsonSerializer.Deserialize<List<VideoGame>>(fileContents);
            }
            catch (JsonException ex)
            {
                _userInteractor.PrintError($"Json in {fileName} File was not " +
                 $"in a valid format. Json body:");
                _userInteractor.PrintError(fileContents);

                throw new JsonException($"{ex.Message} the file is :{fileName}", ex);
            }
        }
    }
}