// Задача 67:
// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int CreateNumber(string msg)    // юзер вводит число
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int SumOfDigits(int num)    // сумма цифр числа
{
    int ost = num % 10;
    if (num != 0)
    {
        ost += SumOfDigits(num / 10);
    }
    return ost;
}


Console.Clear();
Console.WriteLine("Сумма цифр числа\n"
                + "----------------");
int number = CreateNumber("Введите число:\t");

int sum = SumOfDigits(number);
Console.WriteLine($"Сумма цифр:\t{sum}");
