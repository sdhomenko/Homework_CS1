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
            matrix[i, j] = new Random().Next(-9, 10);
        }
    }
    return matrix;
}

//Метод нахождения суммы элементов строки массива
int SumElementRow(int[,] matrix, int i)
{
    int sum = 0;
    int[] row = new int[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        row[j] = matrix[i, j];
        sum += row[j];
    }
    return sum;
}

//Метод находения строка с наименьшей суммой элементов
int MinSumElementRow(int[,] matrix)
{
    int[] sumrow = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumrow[i] = SumElementRow(matrix, i);
        }
        //Console.WriteLine($"строка {i} - сумма элементов строки равна {sumrow[i]}");
    }
    int min = sumrow[0];
    int a = 0;
    for (int i = 0; i < sumrow.Length; i++)
    {
        if (sumrow[i] < min)
        {
            min = sumrow[i];
            a = i;
        }
    }
    return a;
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
Console.WriteLine($"Cтрока с наименьшей суммой элементов - {MinSumElementRow(ourMatrix)}");
Console.WriteLine();