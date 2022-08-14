//  Задайте массив вещественных чисел. Найдите разницу между максимальным и 
//минимальным элементов массива.
//[3 7 22 2 78] -> 76

using System;
using static System.Console;

Clear();

int[] array = GetArray(4, -99, 99);

WriteLine(String.Join(",", array));

int diff=GetDiff(array);

WriteLine($"Разница между максимальным и минимальным значением элементов массива = {diff}");

int GetDiff(int[] array)
{
int imin = array[0];
int imax = array[0];
for (int i = 1; i < array.Length; i++)
{

    if (array[i] < imin)
    {
        imin = array[i];
    }
    if (array[i] > imax)
    {
        imax = array[i];
    }
}
int idiff = imax - imin;
return idiff;
}





int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}