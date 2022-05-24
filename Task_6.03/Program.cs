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
//Создаем треугольника Паскаля ()
int[,] TriangleBuild(int n)
{
    int[,] triangle = new int[n, n];
    for (int i = 0; i < triangle.GetLength(0); i++)
    {
        triangle[i, 0] = 1;
        triangle[i, i] = 1;
    }
    for (int i = 2; i < triangle.GetLength(0); i++)
    {
        for (int j = 1; j <= i; j++)
        {
            triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j];
        }
    }
    return triangle;
}

void PrintMatrix(int[,] matrix)
{
    const int cellWidth = 3;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] != 0)
                Console.Write($"{matrix[i, j],cellWidth}");
        }
        Console.WriteLine();
    }
}

void PrintPascalTriangle(int[,] matrix)
{
    const int cellWidth = 3;
    int col = cellWidth * matrix.GetLength(0);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.SetCursorPosition(col, i + 10);
            if (matrix[i, j] != 0) Console.Write($"{matrix[i, j],cellWidth}");
            col += cellWidth * 2;
        }
        col = cellWidth * matrix.GetLength(0) - cellWidth * (i + 1);
        Console.WriteLine();
    }
}

//Печать только нечетных элементов треугольника Паскаля
void PrintUnevenElPascalTriangle(int[,] matrix)
{
    const int cellWidth = 3;
    int col = cellWidth * matrix.GetLength(0);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.SetCursorPosition(col, i + 10);
            if (matrix[i, j] %2 != 0) Console.Write($"{matrix[i, j],cellWidth}");
            col += cellWidth * 2;
        }
        col = cellWidth * matrix.GetLength(0) - cellWidth * (i + 1);
        Console.WriteLine();
    }
}

int n = InputData();
int[,] triangle = TriangleBuild(n);
//PrintMatrix(triangle);
//PrintPascalTriangle(triangle);
PrintUnevenElPascalTriangle(triangle);
