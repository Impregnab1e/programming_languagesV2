/*
Задача 32. Напишите программу замена элементов массива: положительные элементы заменита на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] > [4, 8, -8, -2]
*/

Console.Clear();

int[] generateArray(int length, int start, int end)
{
    int [] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(start, end + 1);
    }
    return result;
}
int getIntFromUser (string message)
{
    Console.WriteLine(message);
    int userInt = int.Parse(Console.ReadLine());
    return userInt;
}
int [] invertArray(int [] arrayToInvert)
{
    for (int i =0; i < arrayToInvert.Length; i++)
    {
        arrayToInvert[i] = -arrayToInvert[i];
    }
    return arrayToInvert;
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
int length = getIntFromUser("Введите длину массива");
int [] array = generateArray(length, -100, 100);
printArray(array);
int [] invertedArray = invertArray(array);
printArray (invertedArray);