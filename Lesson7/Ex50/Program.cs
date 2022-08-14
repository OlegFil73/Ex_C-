//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

using System;
using static System.Console;

Clear();

Write("Введите размер массива через пробел: ");
string[] nums = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,] array = GetArray(int.Parse(nums[0]), int.Parse(nums[1]), -10, 10);
PrintArray(array);

Console.WriteLine("Ведите первую позицию элемента ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ведите вторую позицию элемента");
int n = Convert.ToInt32(Console.ReadLine());
if (m > array.GetLength(0)-1 && n > array.GetLength(1)-1)
{
    Console.WriteLine("Такого элемента нет");
}
else
{
    int element = array[m, n];
    Console.WriteLine($"{element}");
}

int[,] GetArray(int rows, int columns, int min, int max)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}

