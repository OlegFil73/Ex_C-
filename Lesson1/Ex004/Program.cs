// Задача 4: Напишите программу, которая принимает на вход 
//три числа и выдаёт максимальное из этих чисел.
int a = 5;
int b = 3;
int c = 7;

int max = a;

if (b > a)
{
    max = b;
}
else
{
    max = a;
}

if (c > max)
{
    Console.WriteLine(c);
}
else
{
    Console.WriteLine(max);
}