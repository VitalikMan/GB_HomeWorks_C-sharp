// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

using static System.Console;

Clear();

Write("Введите количество значений в массиве, min-ое и max-ое значения диапазона массива через пробел: ");
string[] inputValues = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[] array = GetArray(int.Parse(inputValues[0]), Convert.ToInt32(inputValues[1]), Convert.ToInt32(inputValues[2]));

int[] GetArray(int size, int minValue, int maxValue)    // метод формирования массива
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)    // метод заполнения массива
{
    Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Write($"{array[i]}, ");
    }
    WriteLine($"{array[array.Length - 1]}]");
}

Write("Полученный массив: ");
PrintArray(array);

// void AmountPositiveNum(int[] array)     // метод вычисления количества вводимых пользователем чисел, которые больше 0 (нуля)
// {
//     int result = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) result++;
//     }
//     Write($"Количество введенных чисел больше 0 (нуля) равно: {result}");
// }

// AmountPositiveNum(array);

int AmountPositiveNum = 0;
foreach (int i in array)        // цикл вычисления количества вводимых пользователем чисел, которые больше 0 (нуля)
{
    AmountPositiveNum += (i > 0) ? 1 : 0;
}
WriteLine($"Количество введенных чисел больше 0 (нуля) равно: {AmountPositiveNum}");
