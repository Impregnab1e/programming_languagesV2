/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

Console.Clear();

int getUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
int N = getUserValue("Введите пятизначное число: ");


int Palindrome(int N)
{
    int FirstNumber = (N / 10000) % 10;
    int SecondNumber = (N / 1000) % 10;
    int FourthNumber = (N / 10) % 10;
    int FifthNumber = N % 10;

    if (N > 9999 && N < 100000)
    {
        if (FirstNumber == FifthNumber && SecondNumber == FourthNumber)
        {
            Console.WriteLine($"Число {N} является палиндромом!");
        }
        else
        {
            Console.WriteLine($"Число {N} не является палиндромом!");
        }
    }
    else
    {
        Console.WriteLine("Введите другое число");
    }
return N;
}
Palindrome(N);

