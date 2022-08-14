//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
//стоящих на нечётных позициях.
//3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

using System;
using static System.Console;

Clear();

int[] array = GetArray(4, -99, 99);

Console.WriteLine(String.Join(",", array));

int sum = 0;
for (int i = 1; i < array.Length; i=i+2)
{
    sum = sum + array[i];
}
WriteLine($"сумма элементов,стоящих на нечетных позициях = {sum}");

int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}

