/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

Console.Clear();

int getUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}


int mult(int A, int B)
{
    int temp = A;
    for (int i = 1; i < B; i++)

    {
        temp = temp * A;
    }
    return temp;
}


int A = getUserValue("Введите число A: ");
int B = getUserValue("Введите число B: ");
int temp = mult(A, B);

Console.WriteLine($"Число {A} в степени {B} это = {temp}");
