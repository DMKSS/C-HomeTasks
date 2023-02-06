// Задача 10: 
// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций 
// (целочисленное деление, остаток от деления).
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int res = RemoveSecondDigit(number);

Console.WriteLine($"результат -> {res}");

int RemoveSecondDigit(int num)
{
    int step1 = number / 10;
    int step2 = step1 % 10;
    int result = step2;
    return result;
}


