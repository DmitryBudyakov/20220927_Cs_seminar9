// Задача 63:
// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int CreateNumber(string msg)    // юзер вводит число
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void NaturalNumbers(int num)    // вывод натуральных чисел от 1 до N
{
    if (num == 0) return;
    NaturalNumbers(num - 1);
    Console.Write($"{num} ");
}

Console.Clear();
Console.WriteLine("Вывод натуральных чисел в промежутке от 1 до N.\n"
                + "-----------------------------------------------");

int number = CreateNumber("Введите число N: ");
NaturalNumbers(number);
