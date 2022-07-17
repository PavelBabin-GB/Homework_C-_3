// Программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Введите Xa");
int xa = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Ya");
int ya = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Za");
int za = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Xb");
int xb = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Yb");
int yb = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Zb");
int zb = int.Parse(Console.ReadLine());

double Distance (int xaLocal, int yaLocal, int xbLocal, int ybLocal, int zaLocal, int zbLocal)
{
    double dis = Math.Sqrt(Math.Pow(xbLocal - xaLocal, 2) + Math.Pow(ybLocal - yaLocal, 2) + 
    Math.Pow(zbLocal - zaLocal, 2));
    return dis;
}
Console.WriteLine(Distance(xa, ya, xb, yb, za, zb)); 