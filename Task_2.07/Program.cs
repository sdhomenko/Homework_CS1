void ThirdNum(int x)
{
    if (x >= -99 && x <= 99)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        Console.WriteLine(Math.Abs((x / 100) % 10));
    }
}
int N = 321;

ThirdNum(N);