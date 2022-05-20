// Задача 2: 
//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//Ввод количества элементов массива
int InputData()
{
    Console.Write("Введите количество элементов для создания массива: ");
    string n = Console.ReadLine();
    int N = Convert.ToInt32(n);
    return N;
}
//Создаем массив из N элементов
double[] CreateNums(int N)
{
    double[] result = new double[N];
    return result;
}
//Метод заполнения массива случайными числами
void SetRandomNums(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next();
    }
}
//Метод для подсчета cуммы элементов массива стоящих на нечетных позициях (с учетом инедекса = 0)
double SumNumsUnevenInd(double[] nums)
{
    double sum = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + nums[i];
        }
    }
    return sum;
}
//Печать элементов массива для проверки
void PrintNums(double[] nums)
{
    Console.WriteLine("Ваш массив:");
    for (int i = 0; i < nums.Length; i++)
    {
        Console.Write($"{nums[i]} {" "}");
    }
}
//метод для вывода данных
void PrintAnswer(double c)
{
    Console.WriteLine($"Сумма элементов массива стоящих на четных позициях = {c}");
}

int N = InputData();

double[] nums = CreateNums(N);

SetRandomNums(nums);
PrintNums(nums);
Console.WriteLine();
PrintAnswer(SumNumsUnevenInd(nums));