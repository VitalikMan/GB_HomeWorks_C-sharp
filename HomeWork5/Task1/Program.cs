// Напишите программу реализующую методы формирования массива, заполненного случайными
// положительными трёхзначными числами, и подсчета количества чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

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

int sum = 0;
foreach (int a in array)    // подсчёт чётных чисел в массиве
{
    sum += a % 2 == 0 ? 1 : 0;
}
WriteLine($"Количество чётных чисел в массиве равна: {sum}");
