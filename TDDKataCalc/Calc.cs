namespace TDDKataCalc
{
    public class Calc
    {
        public int Add(string digits)
        {
            if(digits == "")
                return 0;

            if (digits.Length == 1)
                return -1;

            var numbers = digits.Split(',');
            return Int16.Parse(numbers[0]) + Int16.Parse((numbers[1]));
        }
    }
}