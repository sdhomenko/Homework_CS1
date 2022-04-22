int SecondNum(int x)
{
    if (x >= 100 && x <= 999)
    {
        Console.WriteLine((x / 10) % 10);
    }
    else
    {
        Console.WriteLine("Число не является техзначным");
    }
    return x;
}

int N = 123;

SecondNum(N);