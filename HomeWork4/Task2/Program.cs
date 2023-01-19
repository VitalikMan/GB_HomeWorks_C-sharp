// Напишите программу, реализующую метод, который принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

using static System.Console;

Clear();

Write("Введите число: ");
bool isNum = int.TryParse(ReadLine(), out int Number);
if (!isNum)
{
    WriteLine("Ошибка! Вы ввели не число!");
    return;
}

int result = SumDigitInNumber(Number);

WriteLine($"Сумма цифр числа {Number} равна {result}");

int SumDigitInNumber(int num)
{
    int total = 0;
    while (num > 0)
    {
        total += (num % 10);
        num /= 10;
    }
    return total;
}
