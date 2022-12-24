/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/

Console.Clear();

Console.WriteLine("Введите число");
int Numbers = int.Parse(Console.ReadLine()!);

if (Numbers >= 100 && Numbers < 1000)
{
    int ThirdDigit = Numbers % 10;
    Console.WriteLine($"третья цифра {Numbers} это {ThirdDigit}");
}
else if (Numbers >= 1000 && Numbers < 10000)
{
    int ThirdDigit = (Numbers / 10) % 10;
    Console.WriteLine($"третья цифра {Numbers} это {ThirdDigit}");
}
else if (Numbers >= 10000 && Numbers < 100000)
{
    int ThirdDigit = (Numbers / 100) % 10;
    Console.WriteLine($"третья цифра {Numbers} это {ThirdDigit}");
}
else if (Numbers >= 0 && Numbers <= 99)
{
    Console.Write("Третьей цифры нет");
}