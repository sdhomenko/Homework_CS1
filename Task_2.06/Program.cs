int x = -1000;
if (x <= -1000 && x >= -9999)
{
    Console.WriteLine(-1*((x / 10) % 10));
}
else
{
    Console.WriteLine("Число не является четырехзначным отрицательным числом ");
}