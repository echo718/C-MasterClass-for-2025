namespace Cookbook.Cookbook.Repository
{
    public class IngredientsRepository
    {
        public string Name = "";
        public string Instruction = "";

        public List<IngredientsRepository> GetIngredientsList()
        {
            List<IngredientsRepository> ingredientsList = new List<IngredientsRepository>
        {
            new IngredientsRepository { Name = "Wheat flour", Instruction = "Sieve. Add to other ingredients." },
            new IngredientsRepository { Name = "Coconut flour", Instruction = "Sieve. Add to other ingredients." },
            new IngredientsRepository { Name = "Butter", Instruction = "Melt on low heat. Add to other ingredients." },
            new IngredientsRepository { Name = "Chocolate", Instruction = "Melt in a water bath. Add to other ingredients." },
            new IngredientsRepository { Name = "Sugar", Instruction = "Add to other ingredients." },
            new IngredientsRepository { Name = "Cardamom", Instruction = "Take half a teaspoon. Add to other ingredients." },
            new IngredientsRepository { Name = "Cinnamon", Instruction = "Take half a teaspoon. Add to other ingredients." },
            new IngredientsRepository { Name = "Cocoa powder", Instruction = " Add to other ingredients." },
            };
            return ingredientsList;
        }

        public string getInstruction(int selectNumber)
        {
            return GetIngredientsList()[selectNumber - 1].Instruction;
        }
    }
}