void DoubleMultiple(int a)
{
    if (a % 7 == 0 && a % 23 == 0)
    {
        Console.WriteLine("Кратно");
    }
    else
    {
        Console.WriteLine("Не кратно");
    }
}
int a = 161;

DoubleMultiple(a);