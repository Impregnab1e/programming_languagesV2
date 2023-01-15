/*
Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/

Console.Clear();

int[] GetRandomArray(int length)
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(0, 2);

    }
    return arr;
}


void showArray(int[] array)
{
    Console.Write($"[");

    for (int i = 1; i < array.Length; i++)
    {
        if (i != array.Length - 1)
        {
            Console.Write($"{array[i]},");
        }
        else
        {
            Console.Write($"{array[i]}]");
        }
    }
}

int[] array = GetRandomArray(8);
showArray(array);


