﻿// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int M = 4, N = 8;

int SummaRec(int M, int N)
{
    if (N < M) return 0;
    return N + SummaRec(M, N - 1);
}

Console.Write("Введите целое число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма чисел от {M} до {N} равна {SummaRec(M, N)}");