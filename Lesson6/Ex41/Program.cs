// Пользователь вводит с клавиатуры M чисел. Посчитайте, 
//сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

using System;
using static System.Console;

Clear();
Write("Введите несколько чисел через пробел: ");
int[] array = GetArreyString(ReadLine());

WriteLine($"Количество чисел больше 0 = {PozitivNum(array)}");


int[] GetArreyString(string arrayString)
{
    string[] nums = arrayString.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[nums.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = int.Parse(nums[i]);
    }
    return result;
}

int PozitivNum(int[] inArray)
{
    int k = 0;
    foreach (int item in inArray)
    {
        if (item > 0) k++;
    }
    return k;
}

