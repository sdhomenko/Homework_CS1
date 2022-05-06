//Задача 3: 
//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементами массива.

//Ввод колличества элементов массива
int InputData()
{
    Console.Write("Введите колличество элементов для создания массива: ");
    string n = Console.ReadLine();
    int N = Convert.ToInt32(n);
    return N;
}
//Создаем массив из N вещественных чисел
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
        numbers[i] = new Random().Next(1, 999);
    }
}
//Метод для поиска максимального и минимального элементов массива и вычесления их разницы
double MaxMinDif(double[] nums)
{
    double max = nums[0];
    double min = nums[0];
    double dif = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] > max) max = nums[i];
    }
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] < min) min = nums[i];
    }
    dif = max - min;
    return dif;
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
//Метод для вывода данных
void PrintAnswer(double c)
{
    Console.WriteLine($"{"Разница между максимальным и минимальным элементами массива ="} {c}");
}


int N = InputData();

double[] nums = CreateNums(N);

SetRandomNums(nums);
PrintNums(nums);

Console.WriteLine();
PrintAnswer(MaxMinDif(nums));
