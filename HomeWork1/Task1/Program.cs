// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее,
// а какое меньшее.

// Тест 1: a = 5; b = 7->max = 7
// Тест 2: a = 2 b = 10->max = 10
// Тест 3: a = -9 b = -3->max = -3

using static System.Console;

Clear();

Write("Введите первое число: ");
int a = int.Parse(ReadLine()!);

Write("Введите второе число: ");
int b = int.Parse(ReadLine()!);

// version 1:

if (a > b)
{
    WriteLine($"Наибольшее число: {a}, наименьшее число: {b}");
}
else if (b > a)
{
    WriteLine($"Наибольшее число: {b}, наименьшее число: {a}");
}
else
{
    WriteLine("Оба числа равны!");
}

// version 2:

// int max(int a, int b)
// {
//     int result = a;
//     if (b > result) result = b;
//     return result;
// }

// int[] numbers = { a, b };

// int Max = max(a, b);
// WriteLine($"Максимальное число: {Max}");
