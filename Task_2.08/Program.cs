int FindWeekend(int[] period, int find)
{
    int size = period.Length;
    int index = 0;
    int day = 0;
    while (index < size)
    {
        if (period[index] == find)
        {
            day = find;
        }

        index++;
    }
    if (day == period[5] ^ day == period[6])
    {
        Console.WriteLine("ДА");
    }
    else
    {
        Console.WriteLine("НЕТ");
    }
return day;
}

int[] week = { 1, 2, 3, 4, 5, 6, 7 };

FindWeekend(week, 8);
