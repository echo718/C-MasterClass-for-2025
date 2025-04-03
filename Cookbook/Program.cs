using Cookbook.Cookbook;
using Cookbook.Cookbook.Repository;

var cookBookApp = new CookBookApp();
cookBookApp.Run();

public class CookBookApp()
{
    public void Run()
    {
        new ReadFile().Read();

        /*excute new loop */
        Console.WriteLine("Create a new cookie recipe! Available ingredients are:");

        //print CURRENT recipe list
        List<IngredientsRepository> ingredientsList = new IngredientsRepository().GetIngredientsList();
        for (int i = 1; i <= ingredientsList.Count(); i++)
        {
            Console.WriteLine($"{i}.{ingredientsList[i - 1].Name}");
        }
        var selectNumber = Console.ReadLine();
        var validation = new Validation(selectNumber);
        validation.SelectionResultValidation();
    }
}

