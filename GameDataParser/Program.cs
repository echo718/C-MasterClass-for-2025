using System.Text.Json;
using GameDataParser;

var app = new GameDataParserApp();
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

Console.ReadKey();
public class GameDataParserApp
{
    public void Run()
    {
        string fileName = ReadValidFilePathFromUser();
        var fileContents = File.ReadAllText(fileName);
        var videoGames = DeserializeVideoGamesFrom(fileName, fileContents);
        PrintGames(videoGames);
    }

    private static void PrintGames(List<VideoGame> videoGames)
    {
        if (videoGames.Count > 0)
        {
            Console.WriteLine();
            Console.WriteLine("Loaded games are:");
            foreach (var videoGame in videoGames)
            {
                Console.WriteLine(videoGame);
            }
        }
        else
        {
            Console.WriteLine("No game is printed.");
        }
    }

    private static List<VideoGame> DeserializeVideoGamesFrom(string fileName, string fileContents)
    {
        try
        {
            return JsonSerializer.Deserialize<List<VideoGame>>(fileContents);
        }
        catch (JsonException ex)
        {
            var orginalColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Json in {fileName} File was not " +
            $"in a valid format. Json body:");
            Console.WriteLine(fileContents);
            Console.ForegroundColor = orginalColor;

            throw new JsonException($"{ex.Message} the file is :{fileName}", ex);
        }
    }

    private static string ReadValidFilePathFromUser()
    {
        string fileName = default;

        bool isFilePathValid = false;

        do
        {
            try
            {
                Console.WriteLine("Enter the name of the file you want to read:");
                fileName = Console.ReadLine();


                isFilePathValid = true;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("The file name can't be null.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("The file name can't be empty.");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("The file not exist");
            }
        }
        while (!isFilePathValid);
        return fileName;
    }
}

public class VideoGame
{
    public string Title { get; init; }
    public int ReleaseYear { get; init; }
    public decimal Rating { get; init; }

    public override string ToString() =>
     $"{Title},released in {ReleaseYear},rating:{Rating}";
}
