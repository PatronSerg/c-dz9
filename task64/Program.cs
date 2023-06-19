// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

static void PrintNumbers(int number)
{
    Console.Write(number + ", ");

    if (number > 1)
    {
        PrintNumbers(number - 1);
    }
}

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Натуральные числа от {0} до 1:", N);
PrintNumbers(N);

