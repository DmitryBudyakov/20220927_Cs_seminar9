// Задача 65:
// Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

int CreateNumber(string msg)    // юзер вводит число
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void NaturalNumbersInRange(int num1, int num2)  // вывод натуральных чисел от num1 до num2
{
    if (num2 == num1) Console.Write($"{num2} ");
    if (num1 < num2)
    {
        NaturalNumbersInRange(num1, num2 - 1);
        Console.Write($"{num2} ");
    }
    if (num1 > num2)
    {
        Console.Write($"{num1} ");
        NaturalNumbersInRange(num1 - 1, num2);
    }
}

Console.Clear();
Console.WriteLine("Вывод натуральных чисел в промежутке от M до N.\n"
                + "-----------------------------------------------");
int numberM = CreateNumber("Введите число M: ");
int numberN = CreateNumber("Введите число N: ");

NaturalNumbersInRange(numberM, numberN);
