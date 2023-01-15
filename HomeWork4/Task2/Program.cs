// Напишите программу, реализующую метод, который принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

using static System.Console;

Clear();

Write("Введите число: ");
bool num = int.TryParse(ReadLine(), out int Number);
if (!num)
{
    WriteLine("Ошибка! Вы ввели не число!");
    return;
}

int result = SumDigitInNumber(Number);

WriteLine($"Сумма цифр числа {Number} равна {result}");

int SumDigitInNumber(int Number)
{
    int total = 0;
    while (Number > 0)
    {
        total += (Number % 10);
        Number /= 10;
    }
    return total;
}
