// Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.
 Console.WriteLine("Ведите координату x точки A");
int ax = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("Ведите координату y точки A");
int ay = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("Ведите координату z точки A");
int az = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ведите координату x точки B");
int bx = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("Ведите координату y точки B");
int by = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("Ведите координату z точки B");
int bz = Convert.ToInt32(Console.ReadLine());

double distance (int ax, int ay, int az, int bx, int by, int bz)
{
    int c = (ax - bx) * (ax - bx) + (ay - by) * (ay - by) + (az - bz) * (az - bz);
    double result = Math.Sqrt(c);
    return result;
}
double res = distance (ax, ay, az, bx, by, bz);
Console.WriteLine($"{res} расстояние между A и B");