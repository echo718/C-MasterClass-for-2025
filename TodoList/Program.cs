/*Roll Dice */
Console.WriteLine("Dice rolled. Guess what number it shows in 3 tries.");
Random random = new Random();
int randomNumber = random.Next(1, 7);
Console.WriteLine("Enter your number:");
var userInputNumber = Console.ReadLine();
var rollsDice = new TodoList.RollsDice.RollsDice(userInputNumber, 1, randomNumber);
rollsDice.playDice();

