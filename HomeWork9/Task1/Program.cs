// При решении задач обязательным условием является реализация рекурсивных методов.

// Напишите программу, которая реализует рекурсивный метод вывода всех натуральных чисел в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using static System.Console;

Clear();

WriteLine("Рекурсивный метод вывода натуральных чисел.");
WriteLine();
Write("Введите целое число: ");
bool isNumber = int.TryParse(ReadLine(), out int Number);
if (!isNumber)
{
    WriteLine("Ошибка! Вы ввели не число! Попробуйте снова.");
    return;
}

WriteLine();
WriteLine($"Все натуральные числа в промежутке от {Number} до 1:");
WriteLine();
Write($"N = {Number} -> \"");
PrintNaturalNumbersThroughRecursion(Number);
WriteLine("\"");
WriteLine();




void PrintNaturalNumbersThroughRecursion(int num)       // рекурсивный метод вывода натуральных чисел
{
    if (num > 0)
    {
        if (num == 1)
        {
            Write(num);
        }
        else
        {
            Write($"{num}, ");
            PrintNaturalNumbersThroughRecursion(num - 1);
        }
    }
    else
    {
        if (num == 1)
        {
            Write(num);
        }
        else
        {
            Write($"{num}, ");
            PrintNaturalNumbersThroughRecursion(num + 1);
        }
    }
}
