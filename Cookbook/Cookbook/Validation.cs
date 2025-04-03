using Cookbook.Cookbook.Repository;

namespace Cookbook.Cookbook
{
    public class Validation
    {
        private string? _selectNumber;
        private List<int> _selectNumberList;
        private readonly List<IngredientsRepository> _ingredientsList;

        public Validation(string? SelectNumber)
        {
            _selectNumber = SelectNumber;
            _selectNumberList = new List<int>();
            _ingredientsList = new IngredientsRepository().GetIngredientsList();
        }

        public void SelectionResultValidation()
        {
            var isNumber = int.TryParse(_selectNumber, out int number);
            if (isNumber != true && _selectNumberList.Count == 0)
            {
                Console.WriteLine($"{ConstRepository.NoIngredientsSaved}");
                Console.WriteLine($"{ConstRepository.IngredientSequenceNotExist}");

            }
            else if (isNumber != true && _selectNumberList.Count > 0)
            {
                var saveToFile = new SaveToFile(_selectNumberList);
                saveToFile.SaveFile();
                Console.WriteLine($"{ConstRepository.AddedSuccessfully}");
                Console.WriteLine($"{ConstRepository.Exit}");
            }
            else
            {
                var selectNumber = int.Parse(_selectNumber!);


                if (_selectNumberList.Contains(selectNumber))
                {
                    //if already exist in the current list
                    Console.WriteLine($"{ConstRepository.RecipeAlreadyExist}");
                }
                else if (selectNumber > _ingredientsList.Count() || selectNumber < 1)
                {
                    //if select number not exist in _ingredientsList.Count()
                    Console.WriteLine($"{ConstRepository.SelectCorrectRecipe}");
                }
                else
                {
                    _selectNumberList.Add(selectNumber);
                    var ingredientsList = new IngredientsRepository();
                    var instruction = ingredientsList.getInstruction(selectNumber);
                    Console.WriteLine($"Recipe added:{instruction}");
                }

                Console.WriteLine($"{ConstRepository.Finished}");
                _selectNumber = Console.ReadLine();
                SelectionResultValidation();
            }
        }
    }
}