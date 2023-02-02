/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.Clear();

int getFromUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int getStrRange(int start, int finish)
{
    if (start == finish)
    {
        return start;
    }
    return finish + getStrRange(start, finish-1);
}

int start = getFromUserData("Введите M");
int finish = getFromUserData("Введите N");

int result = getStrRange(start, finish);
Console.WriteLine($"Сумма натуральных элементов в промежутке от {start} до {finish} = {result}");