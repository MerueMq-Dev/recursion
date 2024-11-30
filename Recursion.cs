using System.Collections;
using System.Text;

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
            int positiveNumber = Math.Abs(number);
            if (positiveNumber < 10)
            {
                return positiveNumber;
            }

            return positiveNumber % 10 + SumOfDigits(positiveNumber / 10);
        }

        public static int GetListLength<T>(List<T> list)
        {
            try
            {
                list.RemoveAt(0);
                return 1 + GetListLength(list);
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public static bool IsPalindrome(string text)
        {
            string lowerAlphanumericText = RemoveNonAlphanumericSymbols(text).ToLower();
            switch (lowerAlphanumericText.Length)
            {
                case 0:
                case 1:
                    return true;
                case 2:
                    return lowerAlphanumericText[0] == lowerAlphanumericText[^1];
                default:
                    return lowerAlphanumericText[0] == lowerAlphanumericText[^1] &&
                           IsPalindrome(lowerAlphanumericText.Substring(1,
                               lowerAlphanumericText.Length - 2));
            }
        }

        private static string RemoveNonAlphanumericSymbols(string input)
        {
            StringBuilder result = new StringBuilder();

            foreach (var characters in input)
            {
                if (char.IsLetterOrDigit(characters))
                {
                    result.Append(characters);
                }
            }

            return result.ToString();
        }
    }
}