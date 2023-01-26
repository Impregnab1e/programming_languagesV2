/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

Console.Clear();

int GetDataFromUser(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
int[,] get2DIntArray(int colLength, int rowLength, int start, int end)
{
    int[,] array = new int[colLength, rowLength];
    for (int i = 0; i < colLength; i++)
    {
        for (int j = 0; j < rowLength; j++)
        {
            array[i, j] = new Random().Next(start, end + 1);
            //Console.Write(array[5, 5]);
        }
    }
    return array;
}

void printColor(string data, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(data);
    Console.ResetColor();
}
void checkPositionInMassive(int[,] array)
{

    Console.WriteLine("Введите строку");
    int line = Convert.ToInt32(Console.ReadLine()) - 1;
    Console.WriteLine("Введите колонну");
    int column = Convert.ToInt32(Console.ReadLine()) - 1;
    if (line < 0 | line > array.GetLength(0) - 1 | column < 0 | column > array.GetLength(1) - 1)
    {
        Console.WriteLine("Элемента на заданной позиции нет");
    }
    else
    {
        Console.Write($"Элемент на заданной позиции это = {array[line, column]}");
    }
}
void print2DArray(int[,] array)
{
    Console.Write("\t");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        printColor(j + "\t", ConsoleColor.Yellow);
    }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printColor(i + "\t", ConsoleColor.Yellow);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int colLength = GetDataFromUser("Введите количество строк");
int rowLength = GetDataFromUser("Введите количество столбцов");
int[,] array = get2DIntArray(colLength, rowLength, 0, 100);
print2DArray(array);
Console.WriteLine();
checkPositionInMassive(array);
