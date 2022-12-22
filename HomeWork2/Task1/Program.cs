// Напишите программу, которая принимает на вход трёхзначное число и на выходе
// показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

using static System.Console;

Clear();

Write("Введите число: ");
int a = Convert.ToInt32(ReadLine()!);

int result = a / 10 % 10;

Write(result);
