// Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. Сформировать строку, в которой слова расположены в обратном порядке. В полученной строке слова должны быть также разделены пробелами.

//НЕРЕШЕННО

void Main(string[] args)
{
    string input = "Hello my world";
    string result = ReverseWords(input);
    Console.WriteLine(result);
}
public static string ReverseWords(string str)
{
    string[] words = str.Split(' ');
    Array.Reverse(words);
    return string.Join(" ", words);
}

Main();












// public class Task4
// {
// public static void Main(string[] args)
// {
// // Входная строка со словами, разделенными пробелами
// string input = "Hello my world";
// // Вызов метода для обращения порядка слов в строке
// string result = ReverseWords(input);
// // Вывод результата
// Console.WriteLine(result);
// }
// // Метод для обращения порядка слов в строке
// public static string ReverseWords(string str)
// {
// // Разделение строки на слова
// string[] words = str.Split(' ');
// // Обращение порядка слов
// Array.Reverse(words);
// // Соединение слов обратно в строку с пробелами
// return string.Join(" ", words);
// }
// }
