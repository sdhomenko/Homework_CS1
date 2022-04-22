void SquareCheck(int a, int b)
{
    int x = a;
    int y = b;
    if (y == Math.Pow(x, 2))
    {
        Console.WriteLine("ДА");
    }
    else
    {
        Console.WriteLine("НЕТ");
    }
}
int a = 5, b = 25;
SquareCheck(a, b);