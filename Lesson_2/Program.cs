// Task 1
// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа
/*
int DeleteSecondDigit(int number)
{
    int firstDigit = number / 100;
    int lastDigit = number % 10;

    int result = firstDigit * 10 + lastDigit;

    return result;
}

int randInt = new Random().Next(100, 1000);

int newInt = DeleteSecondDigit(randInt);

Console.WriteLine($"New version of {randInt} is {newInt}");
*/

// Task 2
// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа
/*
int LargestDigit(int number)
{
    int firstDigit = number / 10;
    int lastDigit = number % 10;

    int result = firstDigit;

    if (lastDigit > result) result = lastDigit;

    return result;
}

int randInt = new Random().Next(10, 100);

int newInt = LargestDigit(randInt);

Console.WriteLine($"Largest digit of {randInt} is {newInt}");
*/
// Task 3
// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого
/*
bool IsSquare(int firstInt, int secondInt)
{
    if (firstInt == secondInt * secondInt || secondInt == firstInt * firstInt) return true;
    else return false;
}

int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

bool result = IsSquare(number1, number2);
Console.WriteLine(result);
*/

// Task 4
// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому
/*
bool IsDiv(int firstInt, int secondInt)
{
    if (secondInt % firstInt == 0) return true;
    else return false;
}

int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

bool result = IsDiv(number1, number2);
Console.WriteLine(result);
*/