//Домашнее задание к уроку 3.

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
int Polindrom(int num)
{

    int a = (num / 10000) % 10;
    int b = num % 10;
    int c = (num / 1000) % 10;
    int d = (num % 100) / 10;
    if (a == b && c == d)
        return 1;
    else
        return 0;
}

Console.Write("Введите пятизначное число для проверки, является ли оно палиндромом: ");
int num = Convert.ToInt32(Console.ReadLine());

int number = Polindrom(num);

if(number == 1)
    Console.WriteLine($"{num} - Число полиндром");
if(number == 0) 
    Console.WriteLine($"{num} - Число не полиндром"); 
*/


//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53

/*
double Lenth(double xa, double ya, double xb, double yb, double za, double zb)
{
    double values = Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya) + (zb - za) * (zb - za));
    return values;
}

Console.Write("Введите координаты X точки А: ");
int xa = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты Y точки А: ");
int ya = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты Z точки А: ");
int za = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты X точки Б: ");
int xb = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты Y точки Б: ");
int yb = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты Z точки Б: ");
int zb = Convert.ToInt32(Console.ReadLine());



double distance = Lenth(xa, ya, xb, yb, za, zb);
Console.Write($"A({xa},{ya},{za}). B({xb},{yb},{zb}). -> {distance}");
*/


//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void Qube(int num)
{
    int current = 1;
    while (current <= num)
    {
        Console.Write(current * current * current + " ");
        current++;
    }
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Qube(number);*/


