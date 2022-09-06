// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
// в промежутке от M до N.
//M = 1; N = 5. -> ""1, 2, 3, 4, 5""
//M = 4; N = 8. -> ""4, 6, 7, 8""

using System;
using static System.Console;

Clear();

Write("Ввведите M ");
int m = int.Parse(ReadLine());
Write("Ввведите N ");
int n = int.Parse(ReadLine());

if (m < n)
{
    WriteLine(PrintNumberM(m, n));
}
else
{
    WriteLine(PrintNumberN(n, m));
}

string PrintNumberM(int start, int end)
{
    if (end == start) return end.ToString();
    return (PrintNumberM(start, end - 1) + " " + end);
}

string PrintNumberN(int start, int end)
{
    if (end == start) return end.ToString();
    return (end + " " + PrintNumberN(start, end - 1));
}
