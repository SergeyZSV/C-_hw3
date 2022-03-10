// Задача 19: 
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Polindrom_check (int a)
{
    while(a < 10000 | a > 99999)
    {
        Console.Write("Вы ввели неверное число. Введите пятизначное число: ");
        a = Convert.ToInt32(Console.ReadLine());
    }
    string a_str = Convert.ToString(a);
    if(a_str[0] == a_str[4] && a_str[1] == a_str[3]) Console.WriteLine("Число " + a + " является палиндромом.");
    else Console.WriteLine("Число " + a + " не является палиндромом.");
}

Console.Write("Введите пятизначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
Polindrom_check(a);


