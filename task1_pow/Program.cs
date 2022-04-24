using System;

Console.Clear();
Console.WriteLine("Введи основание и степень через пробел:");
string[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int osn = int.Parse(numbers[0]);
int step = int.Parse(numbers[1]);
Console.WriteLine($"{osn}, {step} -> {pow(osn, step)}");

int pow (int num1, int num2)
{
    int result = 1;
    while(num2 > 0)
    {
        result *= num1;
        num2--;
    }
    return result;
}