using System.Text.Json;

namespace Cookbook.Cookbook
{
    public class SaveToFile
    {
        private List<int> _selectNumberList;

        public SaveToFile(List<int> SelectNumberList)
        {
            _selectNumberList = SelectNumberList;
        }

        public void SaveFile()
        {
            string formattedString = string.Join(",", _selectNumberList);
            List<string> jsonList = new List<string> { formattedString };
            string newJsonString = JsonSerializer.Serialize(jsonList);
            string newList = newJsonString;

            List<string> lines = File.Exists(ConstRepository.FileName)
                ? new List<string>(File.ReadAllLines(ConstRepository.FileName))
                : new List<string>();

            lines.Add(newList);

            File.WriteAllLines(ConstRepository.FileName, lines);
        }
    }

}
