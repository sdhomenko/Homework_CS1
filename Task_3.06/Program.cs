//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27 
//5 -> 1, 8, 27, 64, 125

void SetNums(int[] nums)
{
    int length = nums.Length;
    int index = 0;
    while (index < length)
    {
        nums[index] = index + 1;
        index++;
    }
}

void PrintNums(int[] nums)
{
    int length = nums.Length;
    int index = 0;
    while (index < length)
    {
        Console.Write($"{nums[index]} {" "}");
        index++;
    }
}

void CubNums(int[] nums)
{
    int size = nums.Length;
    int i = 0;

    while (i < size)
    {
        nums[i] = Convert.ToInt32(Math.Pow(nums[i], 3));
        i++;
    }
}

int N = 5;
int[] nums = new int[N];
SetNums(nums);
CubNums(nums);
PrintNums(nums);