﻿// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

static int Sum(int M, int N)
{
    if (M > N)
    {
        return 0;
    }
    return M + Sum(M + 1, N);
}

Console.Write("Введите значение M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());
int sum = Sum(M, N);
Console.WriteLine($"Сумма натуральных чисел в промежутке от {M} до {N}: {sum}");


