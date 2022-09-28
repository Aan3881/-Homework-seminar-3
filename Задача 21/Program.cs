// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.Write("Введите координату X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double Distance(int aX1, int bY1, int cZ1, int dX2, int eY2, int fZ2)
{
    double res = Math.Sqrt(Math.Pow((dX2 - aX1), 2) + Math.Pow((eY2 - bY1), 2) + Math.Pow((fZ2 - cZ1), 2));
    return res;
}

double length = Math.Round(Distance(x1, y1, z1, x2, y2, z2), 2, MidpointRounding.ToZero);
Console.WriteLine(length);