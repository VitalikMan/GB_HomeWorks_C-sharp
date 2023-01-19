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

// int degreeOfNumber(int A)    // <- Исходный вариант с недочётами в коде (использование В как глобальной переменной не очень хорошая практика. И в целом, лучше не использовать одинаковые имена вне и внутри методов..)
// {
//     int total = 1;
//     for (int i = 0; i < B; i++)
//     {
//         total *= A;
//     }
//     return total;
// }

int degreeOfNumber(int num, int step)   // <- Исправленный вариант
{
    int total = 1;
    for (int i = 0; i < step; i++)
    {
        total *= num;
    }
    return total;
}

int result = degreeOfNumber(A, B);

void PrintDegreeOfNumber(int result)
{
    if (A > 0)
    {
        Write($"Число {A} в степени {B} равна {result}");
    }
    else
    {
        Write($"Число {A} в степени {B} равна -{result}");
    }
}

PrintDegreeOfNumber(result);
