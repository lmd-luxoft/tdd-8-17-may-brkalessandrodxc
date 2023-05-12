using Microsoft.VisualBasic;

namespace TDDKataCalc
{
    public class Calc
    {
        public int Add(string digits)
        {
            if (digits == null)
                return -1;

            if (digits == "")
                return 0;

            if (digits.Length == 1)
                return int.Parse(digits);

            var numbers = new string[2];
            if(digits.StartsWith("//"))
            {
                digits = digits.TrimStart('/');
                var parts = digits.Split('\n');
                var separators = parts[0];
                numbers = parts[1].Split(separators);
            }
            else
            {
                char[] separators = new char[] { ',', '\n' };
                numbers = digits.Split(separators);
            }

            if (numbers.Contains(""))
                return -1;

            foreach (var number in numbers)
            {
                if (!int.TryParse(number, System.Globalization.NumberStyles.None, null, out _))
                    return -1;
            }

            return numbers.Aggregate(0, (count, val) => count + int.Parse(val));
        }
    }
}