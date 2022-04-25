void FindDistance2D(int a, int b, int c, int d)
{
    int xa = a, xb = b;
    int ya = c, yb = d;
    double dist;
    dist = Math.Sqrt(Math.Pow(b - a, 2) + Math.Pow(d - c, 2));
    Console.WriteLine (Math.Round(dist, 2));
}
int xa = 7, xb = 1;
int ya = -5, yb = -1;

FindDistance2D(xa, xb, ya, yb);