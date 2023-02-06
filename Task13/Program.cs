// Задача 13: 
// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int res = RemoveSecondDigit(number);

if (number / 100 == 0)
{
    Console.WriteLine($"третьей цифры нет");
}
else
{
    Console.WriteLine($"результат -> {res}");
}
int RemoveSecondDigit(int num)
{
    int step1 = number % 10;
    int result = step1;
    return result;
}

