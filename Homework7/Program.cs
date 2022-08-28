/*
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] CreateRandomDouble2dArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] newArray = new double[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] = Math.Round(Convert.ToDouble(new Random().Next(minValue, maxValue + 1)) + new Random().NextDouble(), 1);
    return newArray;
}

void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
}
Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateRandomDouble2dArray(m, n, min, max);
Show2dArray(myArray);
*/

/*
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
}

void FindElementOfArray(int[,] array, int rowIndex, int columnIndex)
{
    if(rowIndex >= 0 && rowIndex < array.GetLength(0) && columnIndex >= 0 && columnIndex < array.GetLength(1))
        Console.WriteLine($"The element on the position ({rowIndex}; {columnIndex}) is {array[rowIndex, columnIndex]}");
    else Console.WriteLine($"There is not element on the position ({rowIndex}; {columnIndex})");
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of row: ");
int rowNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of column: ");
int columnNumber = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
FindElementOfArray(myArray, rowNumber, columnNumber);
*/

/*
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
}

double[] AverageElementsColumn(int[,] array)
{
    double[] averageArray = new double [array.GetLength(1)];
    for(int j = 0; j < array.GetLength(1); j++)
        {
        double sum = 0;
        for(int i = 0; i < array.GetLength(0); i++)
            sum = sum + array[i, j];
        averageArray[j] = Math.Round(sum / array.GetLength(0), 1);
        }
    return averageArray;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
double[] averageColumnArray = AverageElementsColumn(myArray);
Console.WriteLine("The averages of each column are:");
ShowArray(averageColumnArray);
*/