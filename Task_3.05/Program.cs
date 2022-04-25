// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
void FindDistance3D(int a, int b, int c, int d, int e, int f)
{
    int xa = a, xb = b;
    int ya = c, yb = d;
    int za = e, zb = f;
    double dist;
    dist = Math.Sqrt(Math.Pow(b - a, 2) + Math.Pow(d - c, 2)+ Math.Pow(f - e, 2));
    Console.WriteLine (Math.Round(dist, 2));
}
int xa = 7, xb = 1;
int ya = -5, yb = -1;
int za = 0, zb = 9;

FindDistance3D(xa, xb, ya, yb, za, zb);