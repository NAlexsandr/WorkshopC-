// Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)                 // Метод считает расстояние между двумя точками в 3D
{
    int xDiff = x2 - x1;
    int yDiff = y2 - y1;
    int zDiff = z2 - z1;
    int sum = xDiff*xDiff + yDiff*yDiff + zDiff*yDiff;
    double result = Math.Sqrt(sum);
    
    return result;
}

Console.WriteLine("Введите координаты двух точек в пространстве x1 y1 z1 и x2 y2 z2 : ");

Console.WriteLine("Введите значение x1 для первой точки: ");
int x1Coordinate = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение y1 для первой точки: ");
int y1Coordinate = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение z1 для первой точки: ");
int z1Coordinate = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение x2 для второй точки: ");
int x2Coordinate = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение y2 для второй точки: ");
int y2Coordinate = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение z2 для второй точки: ");
int z2Coordinate = Convert.ToInt32(Console.ReadLine());


double distance = Distance(x1Coordinate, y1Coordinate, z1Coordinate, x2Coordinate, y2Coordinate, z2Coordinate);
double dRound = Math.Round(distance, 2, MidpointRounding.ToZero);

Console.WriteLine($"Расстояние между заданными точками = {dRound}");
