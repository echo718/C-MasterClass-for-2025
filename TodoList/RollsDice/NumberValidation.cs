namespace NumberValidation
{
    public class NumberValidation
    {
        private string? _number;
        public NumberValidation(string? number)
        {
            _number = number;
        }

        public bool isNumberAndWithinCorrectRange()
        {
            bool isNumber = int.TryParse(_number, out int number);
            if (isNumber && _number != null && int.Parse(_number) > 0 && int.Parse(_number) < 7)
            {
                return true;
            }
            return false;
        }



    }
}