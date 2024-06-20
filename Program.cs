// Задача 1
// Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.

// string CharsToString(char[,] chars)пше
// {
//     string result = string.Empty;
//     for (int i = 0; i < chars.GetLength(0); i++)
//     {
//         for (int j = 0; j < chars.GetLength(1); j++)
//         {
//             result += chars[i, j];
//         }
//     }
//     return result;
// }

// char[,] chars = new char[,] {
//     {'a', 'b', 'c', 'd'},
//     {'e', 'f', 'g', 'h'},
//     {'i', 'j', 'k', 'l'}
// };

// Console.WriteLine(CharsToString(chars));

// Задача 2
// Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

// Console.WriteLine("Input word: " );
// string word = Console.ReadLine();
// word = word.ToLower();
// Console.WriteLine("Your word: " );
// System.Console.WriteLine(word);

// Задача 3
// Задайте произвольную строку. Выясните, является ли она палиндромом.

static bool IsPalindrome(string str)
{
    // Убираем пробелы и приводим строку к нижнему регистру
    str = str.Replace(" ", "").ToLower();

    for (int i = 0; i < str.Length / 2; i++)
    {
        if (str[i] != str[str.Length - i - 1])
        {
            return false;
        }
    }

        return true;
}

Console.WriteLine("Введите строку:");
string input = Console.ReadLine();
if (IsPalindrome(input))
{
    Console.WriteLine("Строка является палиндромом.");
}
else
{
    Console.WriteLine("Строка не является палиндромом.");
}


