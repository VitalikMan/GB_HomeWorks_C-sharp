// Напишите программу реализующую методы формирования массива, заполненного случайными
// *вещественными* числами и вычисления разницы между максимальным и минимальным элементов массива.

// [3,3 7,1 22,5 2,2 78,2] -> 76

using static System.Console;

Clear();

Write("Введите количество значений в массиве, min-ое и max-ое значения диапазона массива через пробел: ");
string[] inputValues = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

double[] array = GetArray(int.Parse(inputValues[0]), Convert.ToDouble(inputValues[1]), Convert.ToDouble(inputValues[2]));

double[] GetArray(int size, double minValue, double maxValue)    // метод формирования массива
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble() * (maxValue - minValue) + minValue;
    }
    return array;
}

void printArray(double[] array)    // метод заполнения массива
{
    Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Write($"{array[i]:f2}, ");
    }
    WriteLine($"{array[array.Length - 1]:f2}]");
}

Write("Полученный массив: ");
printArray(array);

void SumDifferenceMinAndMax(double[] array)     // метод вычисления разницы между min и max значениями
{
    double min = array[0];
    double max = array[1];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
    double result = max - min;
    Write($"Разница между {max:f2} и {min:f2} равна: {result:f2}");
}

SumDifferenceMinAndMax(array);
