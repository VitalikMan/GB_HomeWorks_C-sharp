// Напишите программу реализующую методы формирования массива, заполненного случайными
// числами и подсчета суммы элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

using static System.Console;

Clear();

Write("Введите количество значений в массиве, min-ое и max-ое значения диапазона массива через пробел: ");
string[] inputValues = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[] array = GetArray(int.Parse(inputValues[0]), int.Parse(inputValues[1]), int.Parse(inputValues[2]));

int[] GetArray(int size, int minValue, int maxValue)    // метод формирования массива
{
    int[] resultArray = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = random.Next(minValue, maxValue + 1);
    }
    return resultArray;
}

void printArray(int[] array)    // метод заполнения массива
{
    Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Write($"{array[i]}, ");
    }
    WriteLine($"{array[array.Length - 1]}]");
}

Write("Полученный массив: ");
printArray(array);

void CountingTheSumOfElementsAtOddIndices(int[] array)  // метод подсчёта суммы элементов на нечётных позициях в массиве
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += (i % 2 == 1) ? array[i] : 0;
    }
    Write(sum);
}

Write("Сумма элементов стоящих на нечётных позициях в массиве равна: ");
CountingTheSumOfElementsAtOddIndices(array);
