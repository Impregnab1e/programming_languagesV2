/* Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.*/

/*Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/
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
int [] CoppyArray (int[] array)
{
    int [] result = new int [array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        result[i] = array [i];
    }
    return result;
}
void printArray(int[] array)
{
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
Console.Write(array[i] );
if (i < array.Length - 1)
{
Console.Write(", ");
}
}
Console.WriteLine("]");
}

int number = getUserData("Введите количество элементов массива");
int[] array = FillArray(number, -10, 10);
printArray(array);
int [] result = CoppyArray(array);
printArray(result);
