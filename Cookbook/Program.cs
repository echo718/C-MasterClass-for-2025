using Cookbook.Cookbook;

new ReadFile().Read();

/*excute new loop */
Console.WriteLine("Create a new cookie recipe! Available ingredients are:");

//print CURRENT recipe list
List<IngredientsList> ingredientsList = new IngredientsList().GetIngredientsList();
for (int i = 1; i <= ingredientsList.Count(); i++)
{
    Console.WriteLine($"{i}.{ingredientsList[i - 1].Name}");
}
var selectNumber = Console.ReadLine();
var validation = new Validation(selectNumber);
validation.SelectionResultValidation();
