//  Задача 23: 
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Cube_tab(int number)
{
    Console.WriteLine("Таблица кубов для числа " + number + ": ");
    for(int i = 1; i <= number; i++)
    {
        Console.WriteLine(i + "    |    " + Math.Pow(i, 3));
    }
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Cube_tab(n);