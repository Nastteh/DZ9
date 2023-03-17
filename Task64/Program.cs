//Задача 64: Задайте значение N.
// Напишите программу, которая выведет все натуральные числа
// в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void PrintNumbers(int num, int numN)
{
    if (num <= numN)
    {
        PrintNumbers(num + 1, numN);
        Console.Write($"{num} ");
    }
}

Console.Write("Введите натуральное число N: ");
int numN = Convert.ToInt32(Console.ReadLine());
int num = 1;
if (numN > 0)PrintNumbers(num, numN);
else Console.WriteLine("Введено не натуральное число. Начните заново.");
