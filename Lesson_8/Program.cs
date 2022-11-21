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
// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива
/*
void SwapRows(int[,] array, int row1, int row2)
{
    if (row1 >= 0 && row1 < array.GetLength(0) &&
        row2 >= 0 && row2 < array.GetLength(0) &&
        row1 != row2)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[row1, j];
            array[row1, j] = array[row2, j];
            array[row2, j] = temp;
        }
    }
    else Console.WriteLine("Can't change rows!");
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

Console.Write("Enter of the first row to swap: ");
int firstRow = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Enter of the second row to swap: ");
int secondRow = Convert.ToInt32(Console.ReadLine()) - 1;

SwapRows(rand2DArr, firstRow, secondRow);
Show2DArray(rand2DArr);
*/

// Task 2
// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы
// В случае, если это невозможно, программа должна вывести сообщение для пользователя
/*
void MatrixTransposition(int[,] array)
{
    if (array.GetLength(0) == array.GetLength(1))
    {
        for (int i = 1; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < i; j++)
            {
                int temp = array[i, j];
                array[i, j] = array[j, i];
                array[j, i] = temp;
            }
        }
    }
    else Console.WriteLine("Unable to do matrix transformation");
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

MatrixTransposition(rand2DArr);
Show2DArray(rand2DArr);
*/

// Task 3
// Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент

int[] GetMinIndexes(int[,] array)
{
    int[] minIndexes = {0, 0};

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[i, j] < array[minIndexes[0], minIndexes[1]])
            {
                minIndexes[0] = i;
                minIndexes[1] = j;
            }

    return minIndexes;
}

int[,] SquishArray(int[,] array)
{
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int[] minIndexes = GetMinIndexes(array);

    for (int i = 0, k = 0; i < array.GetLength(0); i++, k++)
    {
        if (i != minIndexes[0])
        {
            for (int j = 0, l = 0; j < array.GetLength(1); j++, l++)
                if (j != minIndexes[1])
                    newArray[k, l] = array[i, j];
                else l--;
        }
        else k--;
    }

    return newArray;
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

int[,] squishedArray = SquishArray(rand2DArr);
Show2DArray(squishedArray, "Squished array:");