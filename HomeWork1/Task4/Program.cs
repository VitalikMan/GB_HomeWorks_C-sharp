// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

// Test 1: 5 -> 2, 4
// Test 2: 8 -> 2, 4, 6, 8

using static System.Console;

Clear();

Write("Введите число: ");
int N = int.Parse(ReadLine()!);

Write($"Все четные числа до {N}: ");

int i = 1;

while (i <= N)
{
    if (i % 2 == 0)
    {
        Write(i + " ");
    }
    i++;
}
