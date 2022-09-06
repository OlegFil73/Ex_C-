//Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7

//Программа считает сумму элементов в каждой строке и выдаёт
//номер строки с наименьшей суммой элементов: 1 строка

using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int m = int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int n = int.Parse(ReadLine());

int[,] array = GetArray(m, n, 0, 5);

PrintArray(array);

WriteLine($"Строка с наименьшей суммой - {NumsRows(array)}");

int NumsRows(int[,] inArray)
{
    int rows=0;
    int sum=0;
    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        sum+=inArray[0,i];
    }
    for (int i = 1; i < inArray.GetLength(0); i++)
    {
        int minSum=0;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
           minSum+=inArray[i,j];
        }
        if (sum>minSum)
        {
            sum=minSum;
            rows=i;
        }
    }
return rows;
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