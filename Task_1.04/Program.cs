var N = 0;

var i = 1;

if (N <=1)
{
    Console.Write("Even numbers not found");
}
while (i <= N) 
{
    if (i%2 == 0)
    {
        Console.Write(i);
        Console.Write(" "); 
    }
    i ++;
}