//Задача 1 
//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

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
        numbers[i] = new Random().Next(100, 999);
    }
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
    Console.WriteLine($"Колличество четных элементов массива = {c}");
}
//Метод для подсчета четных элементов массива
int EvenCount(int[] nums)
{
    int count = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] % 2 == 0)
        {
            count = count + 1;
        }
    }
    return count;
}

int N = InputData();

int[] nums = CreateNums(N);

SetRandomNums(nums);
PrintNums(nums);
Console.WriteLine();
PrintAnswer(EvenCount(nums));