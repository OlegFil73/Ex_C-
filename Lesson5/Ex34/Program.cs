// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

using System;
using static System.Console;

Clear();

int[] array = GetArray(4, 100, 999);

Console.WriteLine(String.Join(",", array));
int amount = 0;
foreach (var item in array)
{
    if (item % 2 == 0)
    {
        amount = amount + 1;
    }
}
WriteLine($"количество чётных чисел в массиве = {amount}");

int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}
