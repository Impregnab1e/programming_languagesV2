/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.Clear();

int getUserData(string message)
{
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

double findPointOfIntersection(double k1, double k2, double b1, double b2)
{
    // k1 * x +b1 = k2 * x + b2; k1*x=k2*x+b2-b1;  k1*x - k2*x = b2-b1; x = (b2-b1) / (k1-k2)
    double x = (b2 - b1) / (k1 - k2);
    double y = (k1 * x + b1);
    double y2 = (k2 * x + b2);
    if ( y == y2)
    {
        Console.WriteLine($"Точка пересечения двух прямых = ({x}; {y})");
    }
    else 
    {
        Console.WriteLine($"Точка пересечения двух прямых - отсутствует");
    }
    return x;
}
double b1 = getUserData("Введите b1");
double k1 = getUserData("Введите k1");
double b2 = getUserData("Введите b2");
double k2 = getUserData("Введите k2");

double intersectionPoint = findPointOfIntersection(k1, k2, b1, b2);