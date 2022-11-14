int[] ReturnRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void ShowArray(int[] array, string msg = "Generated array:")
{
    Console.WriteLine(msg);

    // foreach
    foreach (int el in array)
        Console.Write($"{el} ");

    Console.WriteLine("\n");
}

Console.Write("Enter a number of elements: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a minimal possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a maximal possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

// Task 1
// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
/*
void ReverseArray(int[] array)
{
    // for (int i = 0, int j = array.Length; i < j; i++, j--)
    for (int i = 0; i < array.Length / 2; i++)
    {
        int tmp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = tmp;
        // array[i] = array[j];
        // array[j] = array[i];
    }
}

int[] randArray = ReturnRandomArray(num, min, max);
ShowArray(randArray);
ReverseArray(randArray);
ShowArray(randArray, "Reversed array:");
*/

// Task 2
// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b
/*
int[] GetFib(int N, int a, int b)
{
    int[] array = new int[N];
    array[0] = a;
    array[1] = b;
    for (int i = 2; i < N; i++)
        array[i] = array[i - 1] + array[i - 2];

    return array;
}

Console.Write("Enter number of elements: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter firtst element: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second element: ");
int second = Convert.ToInt32(Console.ReadLine());

int[] fibArr = GetFib(number, first, second);
ShowArray(fibArr);
*/

// Task 3
// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования
/*
int[] GetArrayCopy(int[] array)
{
    int[] copy = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
        copy[i] = array[i];

    return copy;
}

int[] randArr = ReturnRandomArray(num, min, max);
ShowArray(randArr);
int[] copiedArr = GetArrayCopy(randArr);
ShowArray(copiedArr);
*/

// Task 4
// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины

bool IsTriangle(int a, int b, int c)
{
    return a + b > c && b + c > a && a + c > b;
}

Console.Write("Enter firtst element: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second element: ");
int second = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter third element: ");
int third = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"IsTriangle({first}, {second}, {third}): {IsTriangle(first, second, third)}");