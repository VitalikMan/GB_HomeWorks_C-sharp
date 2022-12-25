// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

using static System.Console;

Clear();

Write("Введите целое число: ");
bool isParse = int.TryParse(ReadLine(), out int n);
if (!isParse)
{
    Write("Ошибка! Введите число.");
    return;
}

int i = 1;

WriteLine($"Все числа в кубе от 1 до числа {n}: ", i);

while (n > 0 ? i <= n : i >= n)
{
    if (n > 0)
    {
        Write($"| {i} = ");
        Write($"{Math.Pow(i, 3)} |");
        i++;
    }
    else
    {
        Write($"| {i} = ");
        Write($"{Math.Pow(i, 3)} |");
        --i;
    }
}
