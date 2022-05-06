// Задача 2: 
//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int InputData()
{
    Console.Write("Введите число: ");
    string n = Console.ReadLine();
    int N = Convert.ToInt32(n);
    return N;
}

//Метод суммирования цифр числа
int SumElNums(int N)
{
    int result = 0;
    string num = Convert.ToString(N);
    int j = num.Length;
    for (int i = 0; i < j; i++)
    {
        result = result + (N / Convert.ToInt32(Math.Pow(10,i))) % 10;
    }
    return result;
}

//метод для вывода данных
void PrintAnswer(int c)
{
  
    Console.WriteLine($"{"Ответ: сумма цифр числа ="} {c}");


}

int N = InputData();

PrintAnswer(SumElNums(N));


