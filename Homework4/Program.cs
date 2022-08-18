/*
// Задача 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Exponentiation (int number1, int number2)
{
    int exp = 1; 
    for (int i = 1; i <= number2; i++)
        exp = exp * number1;            
    return exp;
}

Console.Write("Input first integer number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number: ");
int b = Convert.ToInt32(Console.ReadLine());

int result = Exponentiation(a, b);
Console.WriteLine($"The number {a} in {b} degree is {result}");
*/



/*
// Задача 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumOfDigit (int number)
{
    int sum = 0; 
    while (number > 0)
        {
        sum = sum + number%10;  
        number = (number - number % 10) / 10;
        }         
    return sum;
}

Console.Write("Input integer number: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = SumOfDigit(a);
Console.WriteLine($"Sum of the digits in the number {a} is {result}");
*/



/*
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] CreateArray(int size)
{
    int [] newArray = new int[size];
    for (int i = 0; i < size; i++)
        {
        Console.Write($"Input {i} element of the array: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());    
        }
    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray (a);
ShowArray(myArray);
*/





