namespace Cookbook.Cookbook
{
    public class PrintExistingRecipes
    {
        private string _existingRecipes;
        private readonly List<IngredientsList> _ingredientsList;

        public PrintExistingRecipes(string ExistingRecipes)
        {
            _existingRecipes = ExistingRecipes;
            _ingredientsList = new IngredientsList().GetIngredientsList();
        }

        public void Print()
        {
            List<string> parts = _existingRecipes.Split(',').ToList();

            // Convert the string array into a List<List<int>> format
            List<int> _existingRecipesList = new List<int>();

            foreach (string part in parts)
            {
                // Convert the numbers to integers and add them to the result list
                int innerList = int.Parse(part);
                _existingRecipesList.Add(innerList);
            }

            for (int i = 0; i < _existingRecipesList.Count(); i++)
            {

                Console.WriteLine($"{_ingredientsList[_existingRecipesList[i] - 1].Name}.{_ingredientsList[_existingRecipesList[i] - 1].Instruction}");
            }

        }
    }
}