using System.Text;

namespace Recursion
{
    public static class Recursion
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

        private static bool IsTextPalindrome(string text, int leftPointer, int rightPointer)
        {
            if (leftPointer >= rightPointer)
                return true;

            if (text[leftPointer] != text[rightPointer])
                return false;

            return IsTextPalindrome(text, leftPointer + 1, rightPointer - 1);
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

        public static void PrintEvenNumbers(List<int> numbers)
        {
            PrintEvenNumbersStartingAt(numbers, 0);
        }

        private static void PrintEvenNumbersStartingAt(List<int> numbers, int index)
        {
            if (index >= numbers.Count)
                return;
            if (numbers[index] % 2 == 0)
                Console.WriteLine(numbers[index]);

            PrintEvenNumbersStartingAt(numbers, index + 1);
        }

        public static void PrintEvenIndexValues<T>(List<T> values)
        {
            PrintEvenIndexValuesFrom(values, 0);
        }

        private static void PrintEvenIndexValuesFrom<T>(List<T> values, int index)
        {
            if (index >= values.Count)
                return;
            Console.WriteLine(values[index]);

            PrintEvenIndexValuesFrom(values, index + 2);
        }

        public static int GetSecondLargestNumber(List<int> numbers)
        {
            if (numbers.Count < 2 || numbers == null)
                throw new ArgumentException("The list must contain at least 2 elements");
            
            return FindSecondLargestNumber(numbers, int.MinValue, int.MinValue, 0);
        }
        private static int FindSecondLargestNumber(List<int> numbers, int largestNumber, 
            int secondLargestNumber, int index)
        {
            if (index == numbers.Count)
            {
                return secondLargestNumber;
            }

            int currentNumber = numbers[index];
            int newLargestNumber = largestNumber;
            int newSecondLargestNumber = secondLargestNumber;
            
            if (largestNumber <= currentNumber)
            {
                newSecondLargestNumber = largestNumber;
                newLargestNumber = currentNumber;
            } else if (secondLargestNumber < currentNumber)
            {
                newSecondLargestNumber= currentNumber;
            }

            return FindSecondLargestNumber(numbers, newLargestNumber, newSecondLargestNumber, index + 1);
        }
    }
}