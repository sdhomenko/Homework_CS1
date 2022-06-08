//ДЗ ЗАДАЧА 2. Найти произведение двух матриц
// Произведение двух матриц АВ имеет смысл только в том случае, 
// когда число столбцов матрицы А совпадает с числом строк матрицы В

// В произведении матриц АВ число строк равно числу строк матрицы А , 
// а число столбцов равно числу столбцов матрицы В.

//Ввод количества строк и столбцов двухмерного массива
(int, int) InputData()
{

    Console.Write("Введите количество строк: ");
    int i = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int j = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    return (i, j);
}

//Создаем массив
int[,] CreateMatrix(int i, int j)
{
    int[,] result = new int[i, j];
    return result;
}

//Заполняем массив числами
void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-9, 10);
        }
    }
}

//Печатаем массив для наглядности
void PrintMatrix(int[,] matrix)
{
    const int cellWidth = 4;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],cellWidth}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
//Метод произведения матриц (с проверкой)
int[,] MatrixMultiplication(int[,] A, int[,] B)
{
    int[,] C = new int[A.GetLength(0), B.GetLength(1)];
    if (A.GetLength(1) != B.GetLength(0))
        return new int[0, 0];
    else for (int k = 0; k < C.GetLength(0); k++)
        {
            for (int l = 0; l < C.GetLength(1); l++)
            {
                C[k, l] = 0;
                for (int q = 0; q < A.GetLength(1); q++)
                {
                    C[k, l] += A[k, q] * B[q, l];
                }
            }
        }
    return C;
}

Console.WriteLine("Введите данные для матрицы A");
(int i, int j) = InputData();
Console.WriteLine("Введите данные для матрицы B");
(int m, int n) = InputData();
int[,] A = CreateMatrix(i, j);
int[,] B = CreateMatrix(m, n);
FillMatrix(A);
Console.WriteLine($"Матрица A");
PrintMatrix(A);
Console.WriteLine($"Матрица B");
FillMatrix(B);
PrintMatrix(B);
Console.WriteLine($"Матрица C");
if (j!=m) Console.WriteLine("Произведение данных матриц не имеет смысла");
else PrintMatrix(MatrixMultiplication(A, B));