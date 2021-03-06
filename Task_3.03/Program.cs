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

void SqNums(int[] nums)
{
    int size = nums.Length;
    int i = 0;

    while (i < size)
    {
        nums[i] = Convert.ToInt32(Math.Pow(nums[i], 2));
        i++;
    }
}

int N = 5;
int[] nums = new int[N];
SetNums(nums);
SqNums(nums);
PrintNums(nums);

