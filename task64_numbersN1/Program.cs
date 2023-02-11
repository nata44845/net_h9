﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int Rec(int n)
{
    if (n==0) return 1;
    Console.WriteLine(Rec(n-1));
    return n+1; 
}

int GetNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}

int num = GetNum("Введите число: ");

Console.WriteLine(Rec(num));
