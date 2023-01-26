/* Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1 */

Console.Clear();

int GetDataFromUser(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
void printColor(string data)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write(data);
    Console.ResetColor();
}
double[,] get2DDoubleArray(int colLength, int rowLength, int start, int end)
{
    double[,] array = new double[colLength, rowLength];
    for (int i = 0; i < colLength; i++)
    {
        for (int j = 0; j < rowLength; j++)
        {
            // array[i,j] = new Random().Next(start*devider, (end+1)*(devider) / (devider+0.0);
            array[i, j] = new Random().Next(start, end + 1) + Math.Round(new Random().NextDouble(), 2);
        }
    }
    return array;
}
void print2DArray(double[,] array)
{
    Console.Write("\t");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        printColor(j + "\t");
    }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printColor(i + "\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int n = GetDataFromUser("Введите количество строк");
int m = GetDataFromUser("Введите количество столбцов");
double[,] array = get2DDoubleArray(n, m, 0, 100);
print2DArray(array);