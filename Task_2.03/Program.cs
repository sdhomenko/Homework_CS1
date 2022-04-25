int MultipleCheck(int a, int b)
{
    int z = 0;
    if (a % b == 0)
    {
        Console.WriteLine("кратно");
    }
    else
    {
        z = a % b;
        Console.WriteLine("не кратно, остаток: ");
        Console.Write(z);
    }
    return z;
}

int c = 36, d = 6;

MultipleCheck(c, d);