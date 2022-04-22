int x = 17;
if (x >= -99 && x <= 99)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine(Math.Abs((x / 100) % 10));
}