/* Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль. Не использовать String!
14212 -> нет
12821 -> да
23432 -> да */

static bool IsPalindrom(string word, bool ignoreCase = true)
{
    if (ignoreCase)
    {
        word = word.ToLowerInvariant();
    }

    var inputArray = word.ToArray();
    var reversedArray = inputArray.Reverse().ToArray();

    return inputArray.SequenceEqual(reversedArray);
}