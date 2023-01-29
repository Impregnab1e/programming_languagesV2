/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

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



void roWLowestSumOfElements(int[,] array)
{
    int sumRow = 0;
    int minRowOfSum = 0;
    int minRow = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        minRow = minRow + array[0, j];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            sumRow = sumRow + array[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minRowOfSum = i;
        }
        sumRow = 0;
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов: {minRowOfSum+1}");
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

int[,] array = get2DIntArray(colLength, rowLength, 0, 10);
print2DArray(array);

Console.WriteLine();

roWLowestSumOfElements(array);
