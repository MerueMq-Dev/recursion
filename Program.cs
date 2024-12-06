// string stringForTesting = "hele2H?";
// bool isPalindrome = Recursion.Recursion.IsPalindrome(stringForTesting);
// Console.WriteLine($" Текст \"{stringForTesting}\" {(isPalindrome ? "является" : "не является" )} палиндромом");

// List<string> filesNames = Recursion.Recursion
//     .GetAllFilesRecursive(@"C:\Users\");
//
// foreach (var filesName in filesNames)
// {
//     Console.WriteLine($"Имя файла: {filesName}");
// }
// Console.WriteLine($"Количество файлов: {filesNames.Count}");

List<string> generatedParentheses = Recursion.Recursion.GenerateParentheses(3);

foreach (var parentheses in generatedParentheses)
{
    Console.WriteLine(parentheses);
}