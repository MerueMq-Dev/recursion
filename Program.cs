// string stringForTesting = "hele2H?";
// bool isPalindrome = Recursion.Recursion.IsPalindrome(stringForTesting);
// Console.WriteLine($" Текст \"{stringForTesting}\" {(isPalindrome ? "является" : "не является" )} палиндромом");

List<string> filesNames = Recursion.Recursion
    .GetAllFilesRecursive(@"C:\Users\Natali\Downloads\images_и_не_только");

foreach (var filesName in filesNames)
{
    Console.WriteLine($"Имя файла: {filesName}");
}

Console.WriteLine($"Количество файлов: {filesNames.Count}");