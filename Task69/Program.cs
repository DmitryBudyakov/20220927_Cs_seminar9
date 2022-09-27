// Задача 69:
// Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int CreateNumber(string msg)    // юзер вводит число
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int DegreeOfNumber(int c, int d)    // возведение в степень
{
    // if (d == 0) return 1;
    // return c *= DegreeOfNumber(c, d - 1);
    return (d == 0) ? 1 : c *= DegreeOfNumber(c, d - 1);    // с тернарным оператором
}

Console.Clear();
Console.WriteLine("Возведение числа А в целую степень B.\n"
                + "-------------------------------------");
int a = CreateNumber("Число А\t\t: ");
int b = CreateNumber("Степень В\t: ");

int degree = DegreeOfNumber(a, b);
Console.WriteLine($"А в степени В\t: {degree}");
