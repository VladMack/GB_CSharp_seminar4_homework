using System;

Console.Clear();
Console.WriteLine("Введи число элементов в массиве:");
int num = int.Parse(Console.ReadLine());
int[] numbersArray = generateArray(num);
Console.WriteLine($"{String.Join(", ", (numbersArray))} -> [{String.Join(", ", (numbersArray))}]");


int[] generateArray(int number)
{
    int[] newAray = new int[number];
    for (int i = 0; i < number; i++)
    {
        newAray[i] = new Random().Next(0, 100);
    }
    return newAray;
}