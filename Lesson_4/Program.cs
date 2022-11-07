// Task 1
// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А

/*
// standart
int ReturnSum(int last_num)
{
    int sum = 0;

    for (int currentNum = 1; currentNum <= last_num; currentNum++)
        sum += currentNum;

    return sum;
}

// recursion
int ReturnSumRec(int last_num)
{
    if (last_num == 1) return 1;

    return last_num + ReturnSumRec(last_num - 1);
}

Console.Write("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sum of numbers from 1 to {num} is {ReturnSum(num)}");
Console.WriteLine($"Sum of numbers from 1 to {num} with recursion is {ReturnSumRec(num)}");
*/

// Task 2
// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе

/*
int ReturnDigits(int number)
{
    int digits = 0;
    int copy = number;
    // while (number / Convert.ToInt32(Math.Pow(10, pow)) > 0)
    // pow++;
    while (copy != 0)
    {
        copy /= 10;
        digits++;
    }

    return digits;
}

Console.Write("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"In number {num} there are {ReturnDigits(num)} digits");
*/

// Task 3
// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N

/*
// standart
int GetFactorial(int number)
{
    int res = 1;

    for (int current = 1; current <= number; current++) res *= current;

    return res;
}

// recursion
int GetFactorialRec(int number)
{
    if (number == 1) return 1;

    return number * GetFactorialRec(number - 1);
}
Console.Write("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{num}! equals {GetFactorialRec(num)}");
*/

// Task 4
// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке

int[] ReturnRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void ShowArray(int[] array)
{
    // foreach
    foreach (int el in array)
        Console.Write($"{el} ");

    Console.WriteLine();
    // for
    // for (int i = 0; i < array.Length; i++)
    // {
    //     int el = array[i];
    //     Console.Write($"{el} ");
    // }
}

Console.Write("Enter a number of elenents: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a minimal possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a maximal possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] randArray = ReturnRandomArray(num, min, max);
Console.WriteLine("Generated array:");
ShowArray(randArray);