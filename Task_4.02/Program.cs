//Задача 1: 
//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//методы для ввода данных
int InputNumsA()
{
    Console.Write("Введите число A: ");
    string A = Console.ReadLine();
    int a = Convert.ToInt32(A);
    return a;
}
int InputNumsB()
{
    Console.Write("Введите натуральное число B: ");
    string B = Console.ReadLine();
    int b = Convert.ToInt32(B);
    return b;
}
//метод проверки числа B и возведения A в степень
double ExponNums(int a, int b)
{
    double result = -1;
    if (b <= 0)
    {
        Console.Write("Число B не является натуральным ");
    }
    else
    {
        result = Math.Pow(a, b);
    }
    return result;
}
//метод для вывода данных
void PrintAnswer(double c)
{
    if (c <= 0)
    {
        Console.Write("");
    }
    else
    {
        Console.WriteLine($"Ответ: A в степени B = {c}");
    }

}

int a = InputNumsA();
int b = InputNumsB();
PrintAnswer(ExponNums(a, b));