/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

Console.Clear();

Console.Write("Введите цифру: ");
int a = int.Parse(Console.ReadLine());

if (a == 1)
{
    Console.Write("Понедельник. Не выходной!");
}
else if (a == 2)
{
    Console.Write("Вторник. Не выходной!");
}
else if (a == 3)
{
    Console.Write("Среда. Не выходной!");
}
else if (a == 4)
{
    Console.Write("Четверг. Не выходной!");
}
else if (a == 5)
{
    Console.Write("Пятница. Не выходной!");
}
else if (a == 6)
{
    Console.Write("Суббота. Да,выходной!");
}
else if (a == 7)
{
    Console.Write("Воскресенье. Да, выходной!");
}
else
{
    Console.Write("Введите другую цифру");
}