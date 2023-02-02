/*Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8*/

int getUserMsg(string msg)
{
    Console.WriteLine(msg);
    int message = int.Parse(Console.ReadLine()!);
    return message;
}

int getRaiseDegree (int numA, int numB)
{
    if (numB ==1)
    {
        return numA;
    }
    return numA * getRaiseDegree (numA, numB-1);
}

int numA = getUserMsg("Введите число А");
int numB = getUserMsg("Введите число B");
int result = getRaiseDegree(numA, numB);
Console.WriteLine(result);