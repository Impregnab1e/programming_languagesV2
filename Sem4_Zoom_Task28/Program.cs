/* Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120 */

Console.Clear();

int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

int getMultiplicationOfRange(int start, int N)
{
    int mult = 1;
    for (int i = start; i <= N; i++)
    {
        mult = mult * i; // sum = sum +1;
    }
    return mult;
}


int N = getUserData("Введите число N для получение произведение чисел");
int mult = getMultiplicationOfRange(1, N);
Console.WriteLine($"произведение чисел от от 1 до {N} = {mult}");