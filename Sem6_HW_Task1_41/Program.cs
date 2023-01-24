/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

Console.Clear();

int getUserData(string message)
{
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

int amountOfPositiveNumbers(int M)
{
    int amountPositiveN = 0;
    for (int i = 0; i < M; i++)
    {

        Console.WriteLine("Введите число: ");
        int number = int.Parse(Console.ReadLine()!);

        if (number > 0)
        {
            amountPositiveN += 1;
        }
    }
    return amountPositiveN;
}
int M = getUserData($"Введите количество чисел");

int sumPositiveN = amountOfPositiveNumbers(M);
Console.WriteLine($"Чисел больше нуля = {sumPositiveN}");