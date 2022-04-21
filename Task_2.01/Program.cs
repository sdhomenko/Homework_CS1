int GetNumber(int x)
{
    int a = x / 10;
    int b = x % 10;
    int max = a;
    if (b > max) max = b;
    return max;
}
int value = new Random().Next(10, 100);
System.Console.WriteLine(value);
System.Console.WriteLine(GetNumber(value));