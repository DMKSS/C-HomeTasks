﻿// Задача 15: 
// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число от 1 до 7: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber > 5)
{
    Console.WriteLine("Это выходной");
}
else
{
    Console.WriteLine("Это рабочий день");
}

