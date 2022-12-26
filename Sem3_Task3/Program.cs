/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

int getUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
int N = getUserValue("Введите число N: ");

int kub(int N)
{
    for (int i = 1; i < N + 1; i++)
    {
        double temp = Math.Pow(i, 3);
        if (i < N)
        { Console.Write($" {temp},"); }
        else
        { Console.Write($" {temp}"); }
    }
return N;
}
kub(N);