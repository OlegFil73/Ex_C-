// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

using System;
using static System.Console;

Clear();

Write("Введите размер массива через пробел: ");
string[] nums = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
double[,] array = GetArray(int.Parse(nums[0]), int.Parse(nums[1]), -10, 10);
PrintArray(array);

double[,] GetArray(int rows, int columns, int min, int max)
{
    double[,] result = new double[rows, columns];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] =(double)(new Random().Next(min*10, (max+1)*10))/10;
        }
    }
    return result;
}

void PrintArray(double[,] doublArray)
{
    for (int i = 0; i < doublArray.GetLength(0); i++)
    {
        for (int j = 0; j < doublArray.GetLength(1); j++)
        {
            Write($"{doublArray[i, j]} ");
        }
        WriteLine();
    }
}