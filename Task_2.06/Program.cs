void SecondMinusNum(int x)
{
    if (x <= -1000 && x >= -9999)
    {
        Console.WriteLine(Math.Abs((x / 10) % 10));
    }
    else
    {
        Console.WriteLine("Число не является отрицательным четырехзначным");
    }
}

int N = -4321;

SecondMinusNum(N);