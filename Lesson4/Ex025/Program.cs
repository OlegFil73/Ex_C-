// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

Console.WriteLine("Ведите число A");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ведите число B");
int b = Convert.ToInt32(Console.ReadLine());

int c = a;
for (int i = 1; i < b; i++)
{
    c = c * a;
}
Console.WriteLine("Число А в степени В равно");
Console.WriteLine(c);