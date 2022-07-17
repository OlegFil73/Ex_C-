//Задача 23
//Напишите программу, которая принимает на вход число (N) и
// выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Ведите число N");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < N + 1; i++)
{
    Console.WriteLine($"{i * i * i}");
}