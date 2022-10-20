// Task 1
// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y)
/*
void WriteQuarterInfo(int quarter)
{
    switch (quarter)
    {
    case 1:
        Console.WriteLine("1 quarter:\nx in (0 ; +inf)\ny in (0 ; +inf)");
        break;

    case 2:
        Console.WriteLine("2 quarter:\nx in (0 ; -inf)\ny in (0 ; +inf)");
        break;

    case 3:
        Console.WriteLine("3 quarter:\nx in (0 ; -inf)\ny in (0 ; -inf)");
        break;

    case 4:
        Console.WriteLine("4 quarter:\nx in (0 ; +inf)\ny in (0 ; -inf)");
        break;

    default:
        Console.WriteLine("Invalid quarter");
        break;
    }
}

Console.Write("Enter quarter number: ");

int quarter = Convert.ToInt32(Console.ReadLine());

WriteQuarter(quarter);
*/

// Task 2
// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X != 0 и Y != 0 и выдаёт номер четверти плоскости, в которой находится эта точка
/*
int ShowQuarter(double x, double y)
{
    int quarter;
    if (x > 0)
    {
        if (y > 0) quarter = 1;
        else quarter = 4;
    }
    else
    {
        if (y > 0) quarter = 2;
        else quarter = 3;
    }
    return quarter;
}

Console.Write("Enter x coordinate: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter y coordinate: ");
double y = Convert.ToDouble(Console.ReadLine());

int quarter = ShowQuarter(x, y);
Console.WriteLine($"Point with coordinates ({x}; {y}) is in {quarter} quarter");
*/

// Task 3
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве
/*
double CalculateDistance(
    double x1, double y1,
    double x2, double y2
    )
{
    double dx = x2 - x1;
    double dy = y2 - y1;

    return Math.Pow(dx * dx + dy * dy , 0.5);
}

Console.Write("Enter x coordinate of 1st point: ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter y coordinate of 1st point: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter x coordinate of 2nd point: ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter y coordinate of 2nd point: ");
double y2 = Convert.ToDouble(Console.ReadLine());

double result = Math.Round(CalculateDistance(x1, y1, x2, y2), 2);
Console.WriteLine($"Distance between points with coordinates ({x1};{y1}) and ({x2};{y2}) is {result}");
*/

// Task 4
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N

void ShowSquares(int limit)
{
    // int count = 1;
    // while (count <= limit)
    // {
    //     Console.Write($"{count * count} ");
    //     count++;
    // }
    for (int i = 1; i <= limit; i++)
    {
        Console.Write($"{i * i} ");
    }
}

int[] ShowSquaresArray(int limit)
    {
        int[] result = new int[limit];
        for (int i = 1; i <= limit; i++)
        {
            result[i - 1] = i * i;
        }
        return result;
    }

Console.Write("Enter number of squares: ");
int number = Convert.ToInt32(Console.ReadLine());
// ShowSquares(number);

int[] res = ShowSquaresArray(number);
foreach (int item in res)
{
    Console.Write($"{item} ");
}