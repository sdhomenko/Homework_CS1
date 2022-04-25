void FindDistance2D(int xa, int xb, int ya, int yb)
{
    double dist;
    dist = Math.Sqrt(Math.Pow(xb - xa, 2) + 
                    Math.Pow(yb - ya, 2));
    Console.WriteLine (Math.Round(dist, 2));
}
int xa = 7, xb = 1;
int ya = -5, yb = -1;

FindDistance2D(xa, xb, ya, yb);