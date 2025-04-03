namespace Cookbook.Cookbook
{
    public class ReadFile
    {
        public void Read()
        {

            if (File.Exists(ConstRepository.FileName))
            {
                string jsonContent = File.ReadAllText(ConstRepository.FileName);
                string[] result = jsonContent.Replace("[", "").Replace("]", "").Split("\"");
                int _reciptSequence = 1;

                for (int i = 0; i < result.Count(); i++)
                {
                    if (!string.IsNullOrWhiteSpace(result[i]))
                    {
                        Console.WriteLine($"*******************{_reciptSequence}*************************");
                        _reciptSequence++;
                        new PrintExistingRecipes(result[i]).Print();
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
            }

        }
    }
}