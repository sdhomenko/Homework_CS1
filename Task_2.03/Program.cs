int MultipleCheck(int a, int b)
{
    int x = a;
    int y = b;
    int z = 0;
    if (x % y == 0)
    {
        Console.WriteLine("кратно");
    }
    else
    {
        z = x % y;
        Console.WriteLine("не кратно, остаток: ");
        Console.Write(z);
    }
    return z;
}

int c = 36, d = 6;

MultipleCheck(c, d);