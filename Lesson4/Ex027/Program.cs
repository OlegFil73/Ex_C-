// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.

Console.WriteLine("Ведите число");
int number = Convert.ToInt32(Console.ReadLine());

int sum = 0;
while (number > 0)
{
    int temporary = number % 10;
    sum = sum + temporary; 
      number = number / 10;
   }
   
Console.WriteLine("Сумма цифр в числе");
Console.WriteLine(sum);