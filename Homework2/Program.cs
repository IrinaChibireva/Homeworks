// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*
// Длинный способ

int FindSecondDigit(int number)
{
    int ed = number % 10;
    int sot = number / 100;

    int des = (number - sot * 100 - ed) / 10;
    return des;
}
*/

/*
// Короткий способ

int FindSecondDigit(int number)
{
    int des = number / 10 % 10;
    return des;
}

Console.Write("Input integer three-digit number: ");
int currentNumber = Convert.ToInt32(Console.ReadLine());

int secondDigit = FindSecondDigit(currentNumber);
Console.WriteLine($"Second digit of the number is {secondDigit}");
*/


/*
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void FindThirdDigit(int number)
{
    if (-100 < number && number < 100)
        {
        Console.WriteLine($"There is no third digit of number {number}");
        }
    
    else if (number <= -100) 
        {
        int positiveNumber = number * (-1);
        while (positiveNumber > 999)
            {
            positiveNumber = positiveNumber / 10;
            }
        int ed = positiveNumber % 10;
        Console.WriteLine($"Third digit of the number is {ed}");
        }
    else if (number >= 100) 
        {
            while (number > 999)
            {
            number = number / 10;
            }
        int ed = number % 10;
        Console.WriteLine($"Third digit of the number is {ed}");
        }
}

Console.Write("Input a number: ");
int currentNumber = Convert.ToInt32(Console.ReadLine());
FindThirdDigit(currentNumber);
*/


/*
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void DayOff(int number)
{
    if(number >= 1 && number <= 5)
        Console.WriteLine("Today is a working day");
    else if(number == 6 ^ number == 7)
        Console.WriteLine("Today is a day off");
    else
        Console.WriteLine("Check spelling");
}

Console.Write("Enter the number of the day of the week: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
DayOff(dayNumber);
*/

/*
// Решение, если вводить день недели словом

void DayOff (string day)
{
    switch (day.ToLower())
    {
        case "понедельник":
            Console.WriteLine("Сегодня будний день");
            break;
        case "вторник":
            Console.WriteLine("Сегодня будний день");
            break;
        case "среда":
            Console.WriteLine("Сегодня будний день");
            break;
        case "четверг":
            Console.WriteLine("Сегодня будний день");
            break;
        case "пятница":
            Console.WriteLine("Сегодня будний день");
            break;
        case "суббота":
            Console.WriteLine("Ура, сегодня выходной!");
            break;
        case "воскресенье":
            Console.WriteLine("Ура, сегодня выходной!");
            break;
        default:
            Console.WriteLine("Проверьте правильность написания");
            break;
    }
}

Console.Write("Введите день недели: ");
string currentDay = Console.ReadLine();
DayOff(currentDay);
*/




