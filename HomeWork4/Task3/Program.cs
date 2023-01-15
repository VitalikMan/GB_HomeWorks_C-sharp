// Напишите программу, реализующую метод, который формирует массив случайных целых чисел
// из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19,6, 1, 33 -> [1, 2, 5, 7, 19,6, 1, 33 ]

using static System.Console;

Clear();

Write("Введите количество элементов в массиве: ");
bool Number = int.TryParse(ReadLine(), out int num);
if (!Number)
{
    Write("Ошибка! Вы ввели не число! Попробуйте ещё раз.");
    return;
}

int[] arr = arrayCreationProcess(num);

int[] arrayCreationProcess(int size) // метод создания массива элементов
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next();
    }
    return array;
}

void PrintArray(int[] array) // метод заполнения массива элементами для вывода
{
    Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Write($"{array[i]}, ");
    }
    Write($"{array[array.Length - 1]}");
    WriteLine("]");
}

PrintArray(arr); // вывод массива
