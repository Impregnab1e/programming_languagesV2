/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива
[3 7 22 2 78] -> 76 */
Console.Clear();

int[] FillArray(int length, int start, int end)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(start, end + 1);
    }
    return array;
}
int getUserData(string message)
{
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine());
    return userData;
}
int Find(int[] array)
{
    int diff = 0; int max = array [0]; int min = array [0];
    for (int i = 0; i < array.Length; i++)
    {
        {
            {
                if (array[i] > max)
                { max = array[i]; }
                else if (array[i] < min)
                { min = array[i]; }
            }
            diff = max - min;
        }
    }
    return diff;
}
void printArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int number = getUserData("Введите количество элементов");
int[] array = FillArray(number, 0, 100);
printArray(array);
int diff = Find(array);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {diff}");