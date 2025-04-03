namespace Cookbook.Cookbook
{
    public class IngredientsList
    {
        public string Name = "";
        public string Instruction = "";

        public List<IngredientsList> GetIngredientsList()
        {
            List<IngredientsList> ingredientsList = new List<IngredientsList>
        {
            new IngredientsList { Name = "Wheat flour", Instruction = "Sieve. Add to other ingredients." },
            new IngredientsList { Name = "Coconut flour", Instruction = "Sieve. Add to other ingredients." },
            new IngredientsList { Name = "Butter", Instruction = "Melt on low heat. Add to other ingredients." },
            new IngredientsList { Name = "Chocolate", Instruction = "Melt in a water bath. Add to other ingredients." },
            new IngredientsList { Name = "Sugar", Instruction = "Add to other ingredients." },
            new IngredientsList { Name = "Cardamom", Instruction = "Take half a teaspoon. Add to other ingredients." },
            new IngredientsList { Name = "Cinnamon", Instruction = "Take half a teaspoon. Add to other ingredients." },
            new IngredientsList { Name = "Cocoa powder", Instruction = " Add to other ingredients." },
            };
            return ingredientsList;
        }

        public string getInstruction(int selectNumber)
        {
            return GetIngredientsList()[selectNumber - 1].Instruction;
        }

    }
}