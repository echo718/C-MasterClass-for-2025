namespace TodoList.RollsDice
{
    class RollsDice
    {
        private string? _diceNumber;
        private int _times;
        private int _randomNumber;

        public RollsDice(string? DiceNumber, int Times, int RandomNumber)
        {
            _diceNumber = DiceNumber;
            _times = Times;
            _randomNumber = RandomNumber;
        }

        public void playDice()
        {
            var validator = new NumberValidation.NumberValidation(_diceNumber);
            bool isNumber = validator.isNumberAndWithinCorrectRange();

            if (_times == 3)
            {
                Console.WriteLine("You already tried three times. Your lose this game.");
                return;
            }

            if (isNumber)
            {
                _times++;
                if (_randomNumber == int.Parse(_diceNumber!))
                {
                    Console.WriteLine("You Win!");
                }
                else
                {
                    Console.WriteLine("Enter your number:");
                    _diceNumber = Console.ReadLine();
                    playDice();
                }

            }
            else if (!isNumber)
            {
                Console.WriteLine("You must enter a number only!");
                Console.WriteLine("Enter your number:");
                _diceNumber = Console.ReadLine();
                playDice();
            }
        }




    }
}
