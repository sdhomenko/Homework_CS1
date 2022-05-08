//Задача 3:
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

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

//Метод заполнения массива числами от 1 до N по порядку 
void SetNumsInOrder(int[] nums)
{
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] = i + 1;
    }
}

//Метод заполнения произвольными числами от x до y
void SetRandomNums(int[] numbers, int x, int y)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(x, y + 1);
    }
}

//Печать элементов массива
void PrintNums(int[] nums)
{
    Console.WriteLine("Ваш массив:");
    for (int i = 0; i < nums.Length; i++)
    { 
        Console.Write($"{nums[i]} {" "}");
    }
}


int N = InputData();

int[] nums = CreateNums(N);

SetRandomNums(nums, 1, 21);

//SetNumsInOrder(nums);

PrintNums(nums);