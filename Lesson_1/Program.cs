//Task 1
/*
Console.Write("Enter first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int square = secondNumber * secondNumber;

if (firstNumber == square)
    Console.WriteLine($"Number {firstNumber} is a square of {secondNumber}");
else
    Console.WriteLine($"Number {firstNumber} is not a square of {secondNumber}");
*/

//Task 2
/*
Console.Write("Enter a positive integer number: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = - number;

while (current <= number)
{
    Console.Write(current + " ");
    current++;
}
*/

//Task 3

Console.Write("Enter a three-digit positive number: ");
int number = Convert.ToInt32(Console.ReadLine());
int res = number % 10;
Console.WriteLine($"Last digit: {res}");