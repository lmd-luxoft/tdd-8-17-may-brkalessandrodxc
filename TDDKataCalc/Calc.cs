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

            throw new ArgumentException();
        }
    }
}