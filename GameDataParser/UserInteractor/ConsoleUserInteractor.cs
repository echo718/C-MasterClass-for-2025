namespace GameDataParser.UserInteraction
{
    public class ConsoleUserInteractor : IUserInteractor
    {
        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
        public void PrintError(string message)
        {
            // var orginalColor = Console.ForegroundColor;
            // Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("message1");
            //Console.ForegroundColor = orginalColor;
        }
        public string ReadValidFilePath()
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

}