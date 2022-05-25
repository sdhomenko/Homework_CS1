// Задача 2: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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
int[,] FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}

//Метод нахождения минимального элемента и удаления строки и столбца данного элемента
int[,] MinElementSearch(int[,] matrix)
{
    int[,] newmatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int min = matrix[0, 0];
    int a = 0;
    int b = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                a = i;
                b = j;
            }
        }
    }
    Console.WriteLine($"Минимальный элемент - {min} ({a},{b})");
    Console.WriteLine("Новый массив:");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i != a && j != b)
            {
                if (i < a)
                {
                    if (j < b) newmatrix[i, j] = matrix[i, j];
                    else newmatrix[i, j - 1] = matrix[i, j];
                }
                else
                {
                    if (j < b) newmatrix[i - 1, j] = matrix[i, j];
                    else newmatrix[i - 1, j - 1] = matrix[i, j];
                }
            }

        }
    }
    return newmatrix;
}

//Печать массива
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

//Решение
(int i, int j) = InputData();
int[,] ourMatrix = FillMatrix(CreateMatrix(i, j));
Console.WriteLine("Ваш массив:");
PrintMatrix(ourMatrix);
PrintMatrix(MinElementSearch(ourMatrix));
Console.WriteLine();