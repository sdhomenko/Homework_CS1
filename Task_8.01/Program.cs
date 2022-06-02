// Задача 1: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

//Метод сортировки элементов строки по убыванию
int[] SortElementRow(int[,] matrix, int i)
{
    int[] row = new int[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        row[j] = matrix[i, j];
    }
    Array.Sort(row);
    Array.Reverse(row);
    return row;
}

//Упорядочение елементов по строкам на убывание
 int[,] SortElementMatrix(int[,] matrix)
{
    int[,] sorted = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int[] row = SortElementRow(matrix, i);
         for (int j = 0; j < matrix.GetLength(1); j++)
         {
            sorted[i,j]=row[j];
         }
     }
     return sorted;
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
Console.WriteLine("Исходный массив");
PrintMatrix(ourMatrix);
Console.WriteLine("Упорядоченный массив");
PrintMatrix(SortElementMatrix(ourMatrix));