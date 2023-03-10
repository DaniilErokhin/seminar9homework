//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
int n = InputInt("Input a positive number: ");
int m = 1;
if (n < 1)
{
    Console.WriteLine("Wrong number");
}
Console.WriteLine(NaturalNumber(n, m));

int NaturalNumber(int n, int m)
{
    if (n == m)
    {
    return n;
    }
    else
    {    
        Console.Write($"{NaturalNumber(n, m + 1)}, ");
        return m;
    }
}
int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
*/
//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int m = InputInt("Input M:");
int n = InputInt("Input N:");
Console.WriteLine($"Sum of elements from {m} to {n} = {CountNaturalSum(m, n)}");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int CountNaturalSum(int m, int n)
{
    if (m == n)
        return n;
    return n + CountNaturalSum(m, n - 1);
}
*/
//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int m = InputInt("Input a number M:");
int n = InputInt("Input a number N:");
Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");
int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}