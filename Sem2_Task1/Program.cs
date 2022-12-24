/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Console.Clear();

Console.WriteLine("Введите трёхзначное число");
int Numbers = int.Parse(Console.ReadLine()!);

if (Numbers > 99 && Numbers < 1000)
{
    int SecondDigit = (Numbers / 10) % 10;
    Console.WriteLine($"вторая цифра числа {Numbers} это {SecondDigit}");
}
else
{
    Console.Write("Введите другое число");
}