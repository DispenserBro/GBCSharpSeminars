int[] ReturnRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void ShowArray(int[] array)
{
    Console.WriteLine("Generated array:");

    // foreach
    foreach (int el in array)
        Console.Write($"{el} ");

    Console.WriteLine("\n");
}

Console.Write("Enter a number of elenents: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a minimal possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a maximal possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

// int[] randArray = ReturnRandomArray(num, min, max);
// ShowArray(randArray);

// Task 1
// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных элементов массива
/*
int GetNegativeSum(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
        if (array[i] < 0) sum += array[i];

    return sum;
}

Console.WriteLine($"Sum of negative elenents: {GetNegativeSum(randArray)}");
*/

// Task 2
// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве
/*
bool IsNumberInArr(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
        if (array[i] == number) return true;
    return false;
}

int[] randArray = ReturnRandomArray(num, min, max);
ShowArray(randArray);
Console.Write("Enter the number to search: ");
int enteredNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Is number {enteredNumber} in array: {IsNumberInArr(randArray, enteredNumber)}");
*/
// Task 3
// Задайте одномерный массив из m случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [a,b]
/*
int GetArrElsInRange(int[] array, int min, int max)
{
    int result = 0;

    for (int i = 0; i < array.Length; i++)
        if (min <= array[i] && array[i] <= max)
            result++;

    return result;
}

int[] randArray = ReturnRandomArray(num, min, max);
ShowArray(randArray);
Console.Write("Enter minimal number of range: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter maximal number of range: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int inRange = GetArrElsInRange(randArray, minValue, maxValue);
Console.WriteLine($"In range [{minValue}, {maxValue}] is {inRange} elements of array");
*/

// Task 4
// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот

void ReturnOppositeArrayValues(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = -array[i];
}

int[] randArray = ReturnRandomArray(num, min, max);
ShowArray(randArray);
ReturnOppositeArrayValues(randArray);
ShowArray(randArray);
