// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
Console.WriteLine("Ведите число");
int a = Convert.ToInt32(Console.ReadLine());

int i = 10;
if (a < 99)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    {
        while (a > 999)

            a = a / i;
        i = i * 10;
    }


    int b = a % 10;
    Console.WriteLine($"Третья цифра заданного числа - {b}");
}
