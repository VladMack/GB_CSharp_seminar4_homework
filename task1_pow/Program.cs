using System;

Console.Clear();
Console.WriteLine("Введи основание и степень через пробел:");
string[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int baseNumber = int.Parse(numbers[0]);
int degree = int.Parse(numbers[1]);
Console.WriteLine($"{baseNumber}, {degree} -> {exponentiation(baseNumber, degree)}");

int exponentiation(int num1, int num2)
{
    int result = 1;
    while (num2 > 0)
    {
        result *= num1;
        num2--;
    }
    return result;
}