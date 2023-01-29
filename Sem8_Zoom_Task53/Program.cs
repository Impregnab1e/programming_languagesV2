/*Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.*/


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
            array [i,j] = new Random().Next(start,end+1);
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

int [,] swapRows(int [,]array, int row1, int row2)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int temp = array[row1,i];
        array [row1,i] = array[row2,i];
        array[row2,i]=temp;
    }
    return array;
}

int colLength = GetDataFromUser("Введите количество строк");
int rowLength = GetDataFromUser("Введите количество столбцов");
int[,] array = get2DIntArray(colLength, rowLength, 0, 100);
print2DArray(array);

int [,] swappedArray = swapRows(array,0,array.GetLength(0)-1);
print2DArray(swappedArray);
