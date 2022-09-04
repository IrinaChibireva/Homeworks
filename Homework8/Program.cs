/*
// Задача 54. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

int[,] Sort2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
        for(int k = 0; k < array.GetLength(1); k++)
            for(int j = 0; j < array.GetLength(1) - 1; j++)
                {
                    if (array[i, j] > array[i, j + 1])
                        {              
                            int temp = array[i, j];
                            array[i, j] = array[i, j + 1];
                            array[i, j + 1] = temp;
                        }
                }
    return array;
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
Console.WriteLine();
Show2dArray(Sort2dArray(myArray));
*/


/*
// Задача 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int FindMinSumRow(int[,] array)
{
    int sum = 0;
    int resultSum = 0;
    int rowNumber = -1;

    for(int j = 0; j < array.GetLength(1); j++)
        {
            resultSum = resultSum + array[0, j];
            rowNumber = 0;
        }

    for(int i = 1; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                    {
                        sum = sum + array[i, j];
                    }
                if(sum < resultSum) 
                    {
                        resultSum = sum;
                        rowNumber = i;
                    }
            }
        
        return rowNumber;
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
Console.WriteLine();
int minSumOfRowNumber = (FindMinSumRow(myArray));
Console.WriteLine($"The index of row with minimum sum of elements is {minSumOfRowNumber}");
*/


/*
// Задача 58. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

int[,] Multiplication(int[,] a, int[,] b)
{
    int[,] m = new int[a.GetLength(0), b.GetLength(1)];
    if (a.GetLength(1) != b.GetLength(0)) 
        {
            Console.WriteLine("These matrices cannot be multiplied");
            return m;
        }
    else
    {
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < b.GetLength(1); j++)
            {
                for (int k = 0; k < b.GetLength(0); k++)
                {    
                    m[i, j] += a[i, k] * b[k, j];                
                }
            }
        }
        return m;
    }
    
}

Console.Write("Input number of rows of first array: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns of first array: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of rows of second array: ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns of second array: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] firstArray = CreateRandom2dArray(m1, n1, min, max);
int[,] secondArray = CreateRandom2dArray(m2, n2, min, max);

Show2dArray(firstArray);
Console.WriteLine();

Show2dArray(secondArray);
Console.WriteLine();

int[,] multipliedArray = Multiplication(firstArray, secondArray);
Show2dArray(multipliedArray);
*/


/*
// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] MakeNumbersUnique(int x, int y, int z, int minValue, int maxValue)
{                 
    if(x * y * z >= maxValue + 1 - minValue) 
        {
            Console.WriteLine("An array of a given size cannot be filled with unique elements. Change array size or value range.");
            int[,,] array = new int[0, 0, 0];
            return array;
        }
    else
        {
            int[,,] array = new int[x, y, z];
            for(int i = 0; i < x; i++)
                for(int j = 0; j < y; j++)
                    for(int k = 0; k < z; k++)
                        {
                            int currentNumber = array[i, j, k];
                            
                            for(int count = 0; count < x * y * z; count++)
                                {
                                    for(int a = 0; a < x; a++)
                                        for(int b = 0; b < y; b++)
                                            for(int c = 0; c < z; c++)
                                                {
                                                    if(currentNumber == array[a, b, c])
                                                        {
                                                            currentNumber = new Random().Next(minValue, maxValue + 1);
                                                            a = 0;
                                                            b = 0;
                                                            c = 0;
                                                            count = 0;
                                                        }
                                                }
                                }                
                            array[i, j, k] = currentNumber;
                        }
            return array;
    }
}

void Show3dArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"{array[i, j, k]} ({i}, {j}, {k})");
            }
        }
    }   

}

Console.Write("Input first dimension size: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second dimension size: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third dimension size: ");
int p = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,,] uniqueArray = MakeNumbersUnique(m, n, p, min, max);
Show3dArray(uniqueArray);
*/

/*
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] CreateSpiralArray(int rows, int columns)
{
    int[,] spiralArray = new int[rows, columns];
    int number = 1;
    for(int k = 0; k < rows / 2; k++)
        {
            int i = k;
            int j = k;
            for(j = k; j < columns - k; j++)
                {
                    if(number <= rows * columns)
                        {
                            spiralArray[i, j] = number;
                            number++;
                        }
                    else return spiralArray;
                }
            j = columns - k - 1;
            for(i = k + 1; i < rows - k; i++)
                {
                    if(number <= rows * columns)
                        {
                            spiralArray[i, j] = number;
                            number++;
                        }
                    else return spiralArray;
                }
            i = rows - k - 1;
            for (j = columns - k - 2; j >= k; j--)
                {
                    if(number <= rows * columns)
                        {
                            spiralArray[i, j] = number;
                            number++;
                        }
                    else return spiralArray;
                }  
            j = k;
            for(i = rows - k - 2; i > k; i--)
                {
                    if(number <= rows * columns)
                        {
                            spiralArray[i, j] = number;
                            number++;
                        }
                    else return spiralArray;
                }          
        }
    return spiralArray;
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

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] mySpiralArray = CreateSpiralArray(m, n);
Show2dArray(mySpiralArray);
*/