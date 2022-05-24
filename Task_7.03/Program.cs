// Сформировать трехмерный массив c не повторяющимися двузначными числами 
// показать его построчно на экран выводя индексы соответствующего элемента

// Ввод количества строк и столбцов двухмерного массива
(int, int, int) InputData()
{
    Console.Write("Введите количество x: ");
    int i = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество y: ");
    int j = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество z: ");
    int k = Convert.ToInt32(Console.ReadLine());
    if (i * j * k > 180)
    {
        Console.WriteLine("Невозможно заполнить данный массив не повторяющимися двузначными числами!");
        return (i = 0, j = 0, k = 0);
    }
    return (i, j, k);
}

//Создаем массив
int[,,] CreateMatrix(int i, int j, int k)
{
    int[,,] result = new int[i, j, k];
    return result;
}

//Заполняем массив числами
int[,,] FillMatrix(int[,,] matrix)
{
    int count = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (count == 100) count = -count+1;
                matrix[i, j, k] = count;
                count++;
            }
        }
    }
    return matrix;
}
//Печатаем массив для наглядности
void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            string result = string.Empty;
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                result += ($" {matrix[i, j, k]} ({i}, {j}, {k})");
            }
            Console.WriteLine(result);
        }
        Console.WriteLine();
    }
}

(int a, int b, int c) = InputData();
int[,,] matrix3d = CreateMatrix(a, b, c);
FillMatrix(matrix3d);
PrintMatrix(matrix3d);
