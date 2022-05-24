//ДЗ ЗАДАЧА 1. 
//Составить частотный словарь элементов двумерного массива

//Ввод количества строк и столбцов двухмерного массива
(int, int) InputData()
{
    Console.Write("Введите количество строк массива: ");
    int i = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов массива: ");
    int j = Convert.ToInt32(Console.ReadLine());
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
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
}

//Печатаем массив для наглядности
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

//Считаем и готовим ответ в виде массива из строк
string[] ElementCounter(int[,] matrix)
{
    string[] nums = new string[matrix.GetLength(0) * matrix.GetLength(1)];
    int k = 0;
    for (int y = 0; y < matrix.GetLength(1); y++)
    {
        for (int x = 0; x < matrix.GetLength(0); x++)
        {
            int w = matrix[x, y];
            int count = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == w) count++;
                }
            }
            nums[k] = $"{matrix[x, y]} встречается {count} раз(а);";
            k++;
        }
    }
    return nums;
}

//Удаляем дубли
string[] DublicateDelete(int[,] matrix)
{
    string[] unsorted = ElementCounter(matrix);
    string[] sorted = unsorted.Distinct().ToArray();
    return sorted;
}

//Печать ответа с дублями для проверки
void PrintCheck(string[] answer)
{
    for (int i = 0; i < answer.Length; i++)
    {
        Console.WriteLine($"{answer[i]}");
    }
}

void PrintAnswer(string[] answer)
{
    for (int i = 0; i < answer.Length; i++)
    {
        Console.WriteLine(answer[i]);
    }
}


(int i, int j) = InputData();
int[,] matrix = CreateMatrix(i, j);
FillMatrix(matrix);
Console.WriteLine("Ваша матрица:");
PrintMatrix(matrix);
Console.WriteLine("Ответ с дублями:");
PrintCheck(ElementCounter(matrix));
Console.WriteLine("Ответ без дублей:");
Console.WriteLine();
PrintAnswer(DublicateDelete(matrix));