﻿//Задача 68: Напишите программу вычисления 
//функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите неотрицательное число M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите неотрицательное число N: ");
int numN = Convert.ToInt32(Console.ReadLine());

int Ackermann(int numM, int numN)
{
    if (numM == 0)
    {
        return numN + 1;
    }
    else if ((numM != 0) && (numN == 0))
    {
        return Ackermann(numM - 1, 1);
    }
    else if ((numM > 0) && (numN > 0))
    {
        return Ackermann(numM - 1, Ackermann(numM, numN - 1));
    }
    else
    {
        return numN + 1;
    }
}

int result = Ackermann(numM, numN);
Console.WriteLine($"Ackermann({numM}, {numN}) = {result}");
