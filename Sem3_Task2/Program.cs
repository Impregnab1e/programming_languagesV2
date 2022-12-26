/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.Clear();

int getUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int userAx = getUserValue("Введите X");
int userAy = getUserValue("Введите Y");
int userAz = getUserValue("Введите Z");

int userBx = getUserValue("Введите X");
int userBy = getUserValue("Введите Y");
int userBz = getUserValue("Введите Z");

double getDistanceCoordinate(int userAx, int userAy, int userAz, int userBx, int userBy, int userBz)
{
    double result = Math.Sqrt(Math.Pow((userAx - userBx), 2) + Math.Pow((userAy - userBy), 2) + Math.Pow((userAz - userBz), 2));
    return result;
}
double distance = getDistanceCoordinate(userAx, userAy, userAz, userBx, userBy, userBz);
Console.WriteLine($"Расстояние между точками в 3D пространстве это {Math.Round(distance,2)}");


