int[,] ReturnRandom2DArray(int rows, int cols, int minValue, int maxValue)
{
    int[,] array = new int[rows, cols];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2DArray(int[,] array, string msg="Generated array:\n")
{
    Console.WriteLine(msg);

    for (int i = 0; i < array.GetLength(0); i++)
        {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");

        Console.WriteLine();
        }

    Console.WriteLine();
}

// Task 1
// Задайте двумерный массив размером m×n, заполненный случайными целыми числами
/*
Console.Write("Enter a number of rows: ");
int numX = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a number of columns: ");
int numY = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a minimal possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a maximal possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] rand2DArr = ReturnRandom2DArray(numX, numY, min, max);
Show2DArray(rand2DArr);
*/

// Task 2
// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран
/*
int[,] CreateIndexSumArray(int rows, int cols)
{
    int[,] array = new int[rows, cols];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
            array[i, j] = i + j;

    return array;
}

Console.Write("Enter a number of rows: ");
int numX = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a number of columns: ");
int numY = Convert.ToInt32(Console.ReadLine());

int[,] new2DArr = CreateIndexSumArray(numX, numY);
Show2DArray(new2DArr);
*/

// Task 3
// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты
/*
void SquareArrEls(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i += 2)
        for (int j = 0; j < array.GetLength(1); j +=2)
            array[i, j] *= array[i, j];
}

Console.Write("Enter a number of rows: ");
int numX = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a number of columns: ");
int numY = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a minimal possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a maximal possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] rand2DArr = ReturnRandom2DArray(numX, numY, min, max);
Show2DArray(rand2DArr);
SquareArrEls(rand2DArr);
Show2DArray(rand2DArr, "Custom array");
*/

// Task 4
// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д

int GetDiagSum(int[,] array)
{
    int sum = 0;

    for (int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
        sum += array[i, i];

    return sum;
}

Console.Write("Enter a number of rows: ");
int numX = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a number of columns: ");
int numY = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a minimal possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a maximal possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] rand2DArr = ReturnRandom2DArray(numX, numY, min, max);
Show2DArray(rand2DArr);
Console.WriteLine($"Sum of elements on main diagonal: {GetDiagSum(rand2DArr)}");