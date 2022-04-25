using System;

Console.Clear();
Console.WriteLine("Введи число:");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"{num} -> {sumNumbers(Math.Abs(num))}");

int sumNumbers(int number)
{
    int sumOfNumbers = 0;
    while (number > 0)
    {
        sumOfNumbers += number % 10;
        number /= 10;
    }
    return sumOfNumbers;
}