namespace Recursion
{
    public class Recursion
    {
        public static int Power(int number, int power)
        {
            switch (power)
            {
                case 0:
                    return 1;
                case 1:
                    return number;
                default:
                    return number * Power(number, power - 1);
            }
        }

        public static int SumOfDigits(int number)
        {
            var positiveNumber = Math.Abs(number);
            if (positiveNumber < 10)
            {
                return positiveNumber;
            }
            var lastDigit = positiveNumber % 10;
            return lastDigit + SumOfDigits(positiveNumber / 10);
        }
    }
}