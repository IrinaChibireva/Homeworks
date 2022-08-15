/*
// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void PalindromCheck(int number)
{
    int digit1 = number / 10000;
    int digit2 = number % 10000 / 1000;
    int digit4 = number % 10000 % 1000 % 100 /10;
    int digit5 = number % 10000 % 1000 % 100 % 10;

        if (digit1 == digit5 && digit2 == digit4)
        {
        Console.WriteLine($"The number {number} is a palindrom");
        }
    else 
        {
        Console.WriteLine($"The number {number} is not a palindrom");
        };
   
}
Console.Write("Input positive five-digit number: ");
int currentNumber = Convert.ToInt32(Console.ReadLine());
PalindromCheck(currentNumber);
*/



/*
// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double Length(double x1,  double y1, double z1, double x2,  double y2, double z2)
{
    double l = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
    return l;
}

Console.Write("Напишите координату первой точки по оси Х: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Напишите координату первой точки по оси У: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Напишите координату первой точки по оси Z: ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.Write("Напишите координату второй точки по оси Х: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Напишите координату второй точки по оси У: ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Напишите координату второй точки по оси Z: ");
double zB = Convert.ToDouble(Console.ReadLine());

double len = Length (xA, yA, zA, xB, yB, zB);
Console.WriteLine($"Расстояние между заданными точками равно {len}");
*/



/*
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Qube (int number)
{
    int i = 1;
    while(i<=number)
    {
        Console.Write(i*i*i + " ");
        i++;
    }
}

Console.Write("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Таблица кубов чисел от 1 до " + num + " : " );
Qube(num);
*/