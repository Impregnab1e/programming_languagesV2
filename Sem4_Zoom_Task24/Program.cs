/*
Задача 24. Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А.
7 > 28;
4 > 10;
8 > 36.
*/

Console.Clear();

int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(mpessage);
    Console.ResetColor();
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

int getSumOfRange (int start, int end)
{
    int sum = 0;
    for (int i = start; i <= end; i++)
    {
        sum += i; // sum = sum +1;
    }
    return sum;
}
