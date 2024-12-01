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
            if (list.Count == 0)
            {
                return 0;
            }

            list.RemoveAt(0);
            return 1 + GetListLength(list);
        }

        public static bool IsPalindrome(string text)
        {
            string lowerAlphanumericText = RemoveNonAlphanumericSymbols(text).ToLower();
            return IsTextPalindrome(lowerAlphanumericText, 0, lowerAlphanumericText.Length - 1);
        }

        private static bool IsTextPalindrome(string text, int left, int right)
        {
            if (left >= right)
                return true;
            
            if (text[left] != text[right])
                return false;
                
            return IsTextPalindrome(text, left + 1, right - 1);
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