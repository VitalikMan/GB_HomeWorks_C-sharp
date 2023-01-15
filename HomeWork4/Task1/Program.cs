// Напишите программу, реализующую метод, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B с использованием цикла.

// В задаче не использовать стандартный метод Pow!

// 3, 5 -> 243 (3⁵)

// 2, 4-> 16

using static System.Console;

Clear();

Write("Введите число для возведения в степень: ");
bool numberA = int.TryParse(ReadLine(), out int A);
if (!numberA)
{
    WriteLine("Ошибка! Вы ввели не число!");
    return;
}

Write($"Введите степень числа {A} для её расчёта: ");
bool numberB = int.TryParse(ReadLine(), out int B);
if (!numberB)
{
    WriteLine("Ошибка! Вы ввели не число!");
    return;
}

int result = degreeOfNumber(A);

if (A > 0)
{
    Write($"Число {A} в степени {B} равна {result}");
}
else
{
    Write($"Число {A} в степени {B} равна -{result}");
}


int degreeOfNumber(int A)
{
    int total = 1;
    for (int i = 0; i < B; i++)
    {
        total *= A;
    }
    return total;
}
