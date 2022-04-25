//Напишите программу, которая принимает 
//на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
//14212 -> нет
//23432 -> да
//12821 -> да
string PalindromCheck(int num)
{
    string result = String.Empty;
    result = Convert.ToString(num);
    int length = result.Length;
    if (num > 9999 && num < 100000)
    {
        if (result[0] == result[4] && result[1] == result[3])
        {
            Console.WriteLine("ДА");
        }
        else
        {
            Console.WriteLine("НЕТ");
        }
    }
    else
    {
        Console.WriteLine("Число не является пятизначным");
    }
    return result;
}

int N = 11111;

PalindromCheck(N);