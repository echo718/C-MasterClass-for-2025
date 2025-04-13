using GameDataParser.Model;

namespace GameDataParser.UserInteraction
{
    public class GamesPrinter : IGamesPrinter
    {

        private readonly IUserInteractor _userInteractor;

        public GamesPrinter(IUserInteractor userInteractor)
        {
            _userInteractor = userInteractor;
        }

        public void Print(List<VideoGame> videoGames)
        {
            if (videoGames.Count > 0)
            {
                //pring new line using envinroment.newline
                _userInteractor.PrintMessage(
                    Environment.NewLine + "Loaded games are:");
                foreach (var videoGame in videoGames)
                {
                    _userInteractor.PrintMessage(videoGame.ToString());
                }
            }
            else
            {
                _userInteractor.PrintMessage("No game are present in the input file.");
            }
        }


    }
}