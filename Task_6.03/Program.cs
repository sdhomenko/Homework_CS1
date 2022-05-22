// ДЗ ЗАДАЧА 3. Показать треугольник Паскаля 
// * Сделать вывод в виде равнобедренного треугольника 
// * Показать только нечетные числа в треугольнике

// Каждое число внутри треугольника Паскаля равно сумме двух чисел, 
// стоящих над ним справа и слева в предыдущей строчке:

//Ввод количества строк треугольника
int InputData()
{
    Console.Write("Введите количество строк треугольника Паскаля: ");
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}
//Печать треугольника Паскаля
void TriangleBuild(int n)
{
    for (int i = 0; i < n; i++)
    {
        int k = 1;
        for (int q = 0; q < n - i; q++)
        {
            Console.Write("   ");
        }
        for (int j = 0; j <= i; j++)
        {
            Console.Write("   {0:d} ", k);
            k = k * (i - j) / (j + 1);
        }
        Console.WriteLine();
        Console.WriteLine();
    }
    Console.WriteLine();
}

//Печать только нечетных элементов треугольника Паскаля
void TriangleBuildUneven(int n)
{
    for (int i = 0; i < n; i++)
    {
        int k = 1;
        for (int q = 0; q < n - i; q++)
        {
            Console.Write("   ");
        }
        for (int j = 0; j <= i; j++)
        {
            if(k%2!=0) Console.Write("   {0:D} ", k);
            else Console.Write("   {0:D} ", " ");
            k = k * (i - j) / (j + 1);
        }
        Console.WriteLine();
        Console.WriteLine();
    }
    Console.WriteLine();
}

int n = InputData();
TriangleBuild(n);
TriangleBuildUneven(n);