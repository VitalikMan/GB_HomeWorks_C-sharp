// Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).

// Test 1: 4 -> да
// Test 1: -3 -> нет
// Test 1: 7 -> нет

using static System.Console;

Clear();

Write("Введите число: ");
int a = int.Parse(ReadLine()!);

if (a % 2 == 0)
{
    WriteLine($"Число {a} является четным.");
}
else
{
    WriteLine($"Число {a} является нечетным.");
}
