/*
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Input first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int b = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b > max) max = b;

Console.WriteLine($"a = {a}, b = {b} -> max = {max}");
*/

/*
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Input first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine($"{a}, {b}, {c} -> max = {max}");
*/

/*
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
    Console.WriteLine($"The number {num} is an even number");
else
    Console.WriteLine($"The number {num} is not an even number");
*/

/*
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Input integer positiv number: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = 1;

while(current <= number)
{
    if (current % 2 == 0) 
        Console.Write(current + " ");
    current++;
}
*/
