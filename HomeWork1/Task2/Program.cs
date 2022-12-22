// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Тест 1: 2, 3, 7 -> 7
// Тест 2: 44, 78, 5 -> 78
// Тест 3: 22, 3, 9 -> 22

using static System.Console;

Clear();

Write("Введите первое число: ");
int a = int.Parse(ReadLine()!);

Write("Введите второе число: ");
int b = int.Parse(ReadLine()!);

Write("Введите третье число: ");
int c = int.Parse(ReadLine()!);

// Вариант № 1:

// int max(int a, int b, int c)
// {
//     int result = a;
//     if (b > result) result = b;
//     if (c > result) result = c;
//     return result;
// }

// int[] numbers = { a, b, c };

// int Max = max(a, b, c);
// WriteLine($"Максимальное число = {Max}");

// Вариант № 2:

if (a > b && a > c)
{
    WriteLine($"Первое введенное число, является максимальным: {a}");
}
else if (b > a && b > c)
{
    WriteLine($"Второе введенное число, является максимальным: {b}");
}
else if (c > a && c > b)
{
    WriteLine($"Третье введенное число, является максимальным: {c}");
}
else
{
    WriteLine("Все числа равны!");
}
