Console.Clear();


int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите элемент под индексом {i} ");
    array[i] = int.Parse(Console.ReadLine());
}


Console.WriteLine($"Вывод массива: {array} ");