// Найти сумму чисел от 1 до А

//Создаем массив из N элементов
int[] CreateNums(int N)
{
    int[] result = new int[N];
    return result;
}

//Метод заполнения массива числами от 1 до N по порядку 
void SetNumsInOrder(int[] nums)
{
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] = i + 1;
    }
}

//Метод заполнения произвольными числами
void SetRandomNums(int[] numbers, int x, int y)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(x, y + 1);
    }
}

//Метод который суммирует элементы
int SumNums(int[] nums)
{
    int result = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        result = result + nums[i];
    }
    return result;
}

//Печать элементов с целью проверки
void PrintNums(int[] nums)
{
    for (int i = 0; i < nums.Length; i++)
    {
        Console.Write($"{nums[i]} {" "}");
    }
}

double MathMethod (double N)
{
    double result = N*(N+1)/2;
    return result;
}

double N = 1000000000;

Console.WriteLine(MathMethod(N));

//int[] nums = CreateNums(N);

//SetRandomNums(nums, 1, 10);

//SetNumsInOrder(nums);

//PrintNums(nums);

//Console.WriteLine();

//Console.WriteLine(SumNums(nums));