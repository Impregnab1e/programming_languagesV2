/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

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

int colLength = GetDataFromUser("Введите количество строк");
int rowLength = GetDataFromUser("Введите количество столбцов");

void avgOfColumm(int[,] array)
{
    
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double result = 0;
        double result2 = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            result = result + array[i, j];
            result2 = result /colLength;
        }
        Console.WriteLine($"Среднее орифметическое столбца {j} это {result2}");
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



int[,] array = get2DIntArray(colLength, rowLength, 0, 100);
print2DArray(array);
Console.WriteLine();
avgOfColumm(array);
