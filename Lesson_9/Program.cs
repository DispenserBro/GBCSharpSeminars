// Task 1
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N
/*
void ShowNumbers(int finalNumber)
{
    if (finalNumber > 1)
        ShowNumbers(finalNumber - 1);

    Console.Write($"{finalNumber} ");
}

ShowNumbers(5);
*/

// Task 2
// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр
/*
int RecDigsSum(int number)
{
    if (number != 0)
        return number % 10 + RecDigsSum(number / 10);
    return 0;
}

Console.WriteLine(RecDigsSum(3345));
*/

// Task 3
// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N
/*
void ShowNumbers(int m, int n)
{
    if (m > n)
    {
        ShowNumbers(m, n + 1);
        Console.Write($"{n} ");
    }
    else if (n > m)
    {
        Console.Write($"{m} ");
        ShowNumbers(m + 1, n);
    }
    else
        Console.Write($"{m} ");

}

ShowNumbers(5, 10);
*/

// Task 4
// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B

double CustomPower(double number, double power)
{
    if (power > 0)
        return CustomPower(number, power - 1) * number;
    else if (power < 0)
        return CustomPower(number, power + 1) / number;
    else
        return 1;
}

Console.WriteLine(CustomPower(2, 3));
Console.WriteLine(CustomPower(2, -3));