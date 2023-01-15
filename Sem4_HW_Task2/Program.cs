/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11;
82 -> 10;
9012 -> 12.
*/

Console.Clear();

int getUserData(string message)
{
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

int number = getUserData("Введите число");

int getSumFromNumber(int number)
{
    int sum1 = 0;
    while (number != 0)
    {
        sum1 = sum1 + number %10;
        number = number / 10;
    }
    return sum1;
}

int sum1 = getSumFromNumber(number);
Console.WriteLine($"Сумма цифр в числе {number} это = {sum1}");

