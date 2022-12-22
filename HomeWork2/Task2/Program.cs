// // Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// // что третьей цифры нет.

// // 645 -> 6

// // 78 -> третьей цифры нет

// // 32679 -> 6

using static System.Console;

Clear();

// int a = new Random().Next(0, 1000000);              /// version 1: with a random number

Write("Введите число: ");                           /// version 2: with user input
int a = Convert.ToInt32(ReadLine()!);

int result;

if (a > 0 && a >= 100 && a < 1000)
{
    result = a % 10;
    Write($"Третья цифра числа {a} равна {result}");
}
else if (a > 0 && a >= 1000 && a < 10000)
{
    result = a / 10 % 10;
    Write($"Третья цифра числа {a} равна {result}");
}
else if (a > 0 && a >= 10000 && a < 100000)
{
    result = a / 100 % 10;
    Write($"Третья цифра числа {a} равна {result}");
}
else if (a > 0 && a >= 100000 && a <= 1000000)
{
    result = a / 1000 % 10;
    Write($"Третья цифра числа {a} равна {result}");
}
else if (a > 0 && a > 1000000)
{
    Write("Превышено число для вычисления. Введите число меньше 1000000");
}
else if (a > 0 && a < 100)
{
    Write("В числе нет третьей цифры");
}
else if (a <= 0)
{
    Write("Введите число больше 0");
}
