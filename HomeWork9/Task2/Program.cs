// При решении задач обязательным условием является реализация рекурсивных методов

// Напишите программу, которая реализует рекурсивный метод нахождения суммы
// натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using static System.Console;

Clear();

WriteLine("Рекурсивный метод нахождения суммы натуральных элементов в промежутке от M до N.");
WriteLine();
Write("Введите первое и второе число через пробел: ");
string[] par = ReadLine()!.Split(new string[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries);
int M = int.Parse(par[0]);
int N = int.Parse(par[1]);

WriteLine();
WriteLine($"Сумма натуральных элементов в промежутке от {M} до {N}:");
WriteLine();
Write($"M = {M}; N = {N} -> ");
WriteLine(SumNumbersThroughRecursion(M, N));
WriteLine();

int SumNumbersThroughRecursion(int numberM, int numberN)
{
    if (numberM > numberN)
    {
        int temp = numberM;
        numberM = numberN;
        numberN = temp;
    }
    if (numberM == numberN) return numberM;
    else
    {
        return SumNumbersThroughRecursion(numberM + 1, numberN) + numberM;
    }
}
