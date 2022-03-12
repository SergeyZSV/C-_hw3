// Задача 1. На ввод подаётся номер четверти. Создаются 3 случайные точки в этой четверти. Определите самый оптимальный маршрут для торгового менеджера, который выезжает из центра координат.

Random rand = new Random();

int Rand_x (int chetv)
{
    int mod_x = -1;
    int x = rand.Next(1, 100);
    switch(chetv)
    {
        case 2:
            x = x * mod_x;
            break;
        case 3:
            x = x * mod_x;
            break;
    }
    return x;
}

int Rand_y (int chetv)
{
    int mod_y = -1;
    int y = rand.Next(1, 100);
    switch(chetv)
    {
        case 3:
            y = y * mod_y;
            break;
        case 4:
            y = y * mod_y;
            break;
    }
    return y;
}

double Dist_dots(int x1, int x2, int y1, int y2)
{
        double dist = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        return dist;
}

int x0 = 0;
int y0 = 0;
int ch = Convert.ToInt32(Console.ReadLine());

int x1 = Rand_x(ch);
int y1 = Rand_y(ch);
int x2 = Rand_x(ch);
int y2 = Rand_y(ch);
int x3 = Rand_x(ch);
int y3 = Rand_y(ch);

Console.WriteLine("Даны точки:");
Console.WriteLine("Точка X0Y0: " + "(" + x0 + " , " + y0 + ")");
Console.WriteLine("Точка X1Y1: " + "(" + x1 + " , " + y1 + ")");
Console.WriteLine("Точка X2Y2: " + "(" + x2 + " , " + y2 + ")");
Console.WriteLine("Точка X3Y3: " + "(" + x3 + " , " + y3 + ")");

Console.WriteLine("Оптимальный маршрут торгового менеджера: ");

if(Dist_dots(x0 , y0, x1, y1) < Dist_dots(x0 , y0, x2, y2) && Dist_dots(x0 , y0, x1, y1) < Dist_dots(x0 , y0, x3, y3))
{
    Console.Write("x0y0 -> x1y1");
    if(Dist_dots(x1 , y1, x2, y2) < Dist_dots(x1 , y1, x3, y3))
    {
        Console.Write(" -> x2y2 -> x3y3");
    }
    else
    {
        Console.Write(" -> x3y3 -> x2y2");
    }
}
if(Dist_dots(x0 , y0, x2, y2) < Dist_dots(x0 , y0, x1, y1) && Dist_dots(x0 , y0, x1, y1) < Dist_dots(x0 , y0, x3, y3))
{
    Console.Write("x0y0 -> x2y2");
    if(Dist_dots(x2 , y2, x1, y1) < Dist_dots(x2 , y2, x3, y3))
    {
    Console.Write(" -> x1y1 -> x3y3");
    }
    else
    {
    Console.Write(" -> x3y3 -> x1y1");
    }
}
if(Dist_dots(x0, y0, x3, y3) < Dist_dots(x0 , y0, x1, y1) && Dist_dots(x0 , y0, x1, y1) < Dist_dots(x0 , y0, x2, y2))
{
    Console.Write("x0y0 -> x3y3");
    if(Dist_dots(x3 , y3, x1, y1) < Dist_dots(x3, y3, x2, y2))
    {
    Console.Write(" -> x1y1 -> x2y2");
    }
    else
    {
    Console.WriteLine(" -> x2y2 -> x1y1");
    }
}

