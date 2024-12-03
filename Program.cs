// string stringForTesting = "hele2H?";
// bool isPalindrome = Recursion.Recursion.IsPalindrome(stringForTesting);
// Console.WriteLine($" Текст \"{stringForTesting}\" {(isPalindrome ? "является" : "не является" )} палиндромом");

List<int> testData = new List<int> { 2, 5, 4, 3, 5 };

List<int> testData2 = new List<int> { 2, 3, 5, 4 };

List<int> testData3 = new List<int> { 5, 4 };

int testResult1 = Recursion.Recursion.GetSecondLargestNumber(testData);
Console.WriteLine($"Test data: {testResult1}");

int testResult2 = Recursion.Recursion.GetSecondLargestNumber(testData2);
Console.WriteLine($"Test data 2: {testResult2}");

int testResult3 = Recursion.Recursion.GetSecondLargestNumber(testData3);
Console.WriteLine($"Test data 3: {testResult3}");