// Задача 2: 
//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//Ввод колличества элементов массива
int InputData()
{
    Console.Write("Введите колличество элементов для создания массива: ");
    string n = Console.ReadLine();
    int N = Convert.ToInt32(n);
    return N;
}
//Создаем массив из N элементов
int[] CreateNums(int N)
{
    int[] result = new int[N];
    return result;
}
//Метод заполнения массива произвольными положительными трехзначными числами
void SetRandomNums(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1, 1000);
    }
}
//Метод для подсчета cуммы элементов массива стоящих на четных позициях (с учетом инедекса = 0)
int SumNumsEvenInd(int[] nums)
{
    int sum = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (i % 2 > 0 || i % 2 < 0)
        {}
        else
        {
            sum = sum + nums[i];
        }
    }
    return sum;
}
//Печать элементов массивадля проверки
void PrintNums(int[] nums)
{
    Console.WriteLine("Ваш массив:");
    for (int i = 0; i < nums.Length; i++)
    {

        Console.Write($"{nums[i]} {" "}");
    }
}
//метод для вывода данных
void PrintAnswer(int c)
{

    Console.WriteLine($"{"Сумма элементов массива стоящих на четных позициях ="} {c}");


}

int N = InputData();

int[] nums = CreateNums(N);

SetRandomNums(nums);
PrintNums(nums);
PrintAnswer(SumNumsEvenInd(nums));