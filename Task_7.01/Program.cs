// Спирально заполнить двумерный массив:
//   1  2  3  4
//  12 13 14  5
//  11 16 15  6
//  10  9  8  7

//Ввод количества строк и столбцов двухмерного массива
int InputData()
{
    Console.Write("Задайте размер массива: ");
    int s = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    return (s);
}

//Создаем массив
int[,] CreateMatrix(int i)
{
    int j = i;
    int[,] result = new int[i, j];
    return result;
}

//Заполняем массив числами по порядку спирально 
int[,] SpiralFillMatrix(int[,] matrix)
{
    int start = 1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i; j < matrix.GetLength(0) - i; j++)
        {
            matrix[i, j] = start++;
        }
        for (int k = i + 1; k < matrix.GetLength(0) - i; k++)
        {
            matrix[k, matrix.GetLength(0) - 1 - i] = start++;
        }
        for (int j = matrix.GetLength(0) - i - 2; j > i; j--)
        {
            matrix[matrix.GetLength(0) - i - 1, j] = start++;
        }
        for (int k = matrix.GetLength(0) - i - 1; k > i; k--)
        {
            matrix[k, i] = start++;
        }
    }
    return matrix;
}

//Печатаем массив для наглядности
void PrintMatrix(int[,] matrix)
{
    const int cellWidth = 3;
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

int size = InputData();
int[,] spiral = CreateMatrix(size);
PrintMatrix(SpiralFillMatrix(spiral));