/*Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9*/

int getUserMsg(string msg)
{
    Console.WriteLine(msg);
    int message = int.Parse(Console.ReadLine()!);
    return message;
}

int getSumOfDig (int number)
{
    if (number == 0)
    {
        return 0;
    }
    return number %10 + getSumOfDig (number /10);
}

int num = getUserMsg("Введите число ");
int result = getSumOfDig(num);
Console.WriteLine(result);
