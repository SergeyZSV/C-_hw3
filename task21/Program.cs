//  Задача 21: 
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double Dist(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double dist = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return dist;
}

Console.WriteLine("Введите координаты двух точек A и B.");
Console.Write("Координа X точки A: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Координа Y точки A: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Координа Z точки A: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Координа X точки B: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Координа Y точки B: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Координа Z точки B: ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Расстояние между точками A и B  в пространстве = " + Dist(x1, y1, z1, x2, y2, z2));