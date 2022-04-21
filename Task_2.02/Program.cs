int x = 1000;

if (x <= 99 ^ x >= 1000)
{
    Console.WriteLine("Число не является техзначным");
}
else
{
    Console.WriteLine((x / 10) % 10);
} 