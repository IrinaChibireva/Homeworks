/*
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] CreateUserArray(int size)
{
int [] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} number: ");
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

int CountPositiveNumbers(int[] array)
{
    int count = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
   return count;
}
Console.Write("Input how many numbers would you like to enter: ");
int m = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateUserArray (m);
ShowArray(myArray);
int result = CountPositiveNumbers(myArray);
Console.WriteLine($"There are {result} positive numbers");
*/

/*
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void PointOfIntersection(double a1, double c1, double a2, double c2)
{
    double x = (c2 - c1) / (a1 - a2);
    double y = a1 * x + c1;
    if (a1 == a2) Console.WriteLine("These lines are parallel");
    else Console.WriteLine($"The point of intersection of the lines has coordinates: {x}; {y}");
}

Console.WriteLine("Input the value of the coefficient k1 of the straight line given by the equation: y = k1 * x + b1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input the value of the coefficient b1 of the straight line given by the equation: y = k1 * x + b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input the value of the coefficient k2 of the straight line given by the equation: y = k2 * x + b2");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input the value of the coefficient b2 of the straight line given by the equation: y = k2 * x + b2");
double b2 = Convert.ToDouble(Console.ReadLine());

PointOfIntersection(k1, b1, k2, b2);
*/