// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

using static System.Console;

Clear();

WriteLine("Для создания таблицы, введите значения, где:");
WriteLine("    1) кол-во строк;");
WriteLine("    2) кол-во столбцов;");
WriteLine("    3) min-ый диапазон случайного значения;");
WriteLine("    4) max-ый диапазон случайного значения;");
WriteLine();
Write("Введите значения через пробел, для формирования таблицы: ");
string[] par = ReadLine()!.Split(new string[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries);
int[,] matrixArray = GetMatrixArray(int.Parse(par[0]), int.Parse(par[1]), Convert.ToInt32(par[2]), Convert.ToInt32(par[3]));

WriteLine();
WriteLine("Полученная таблица: ");
PrintMatrixArray(matrixArray);
WriteLine();
PrintSumMinRow(matrixArray);




int[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue)    // метод формирования таблицы
{
    int[,] resultArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return resultArray;
}

void PrintMatrixArray(int[,] matrixArray)       // метод вывода заполненной таблицы
{
    for (int i = 0; i < matrixArray.GetLength(0); i++)
    {
        for (int j = 0; j < matrixArray.GetLength(1); j++)
        {
            Write($"{matrixArray[i, j],6}");
        }
        WriteLine();
    }
}

void PrintSumMinRow(int[,] matrixArray)      // метод вычисления строки с min-ой суммой элементов в таблице и ее вывод
{
    int[] resultArr = new int[matrixArray.GetLength(0)];
    for (int i = 0; i < matrixArray.GetLength(0); i++)      // вычисляем сумму элементов по каждой строке в таблице
        for (int j = 0; j < matrixArray.GetLength(1); j++)
        {
            int a = i;
            resultArr[a] += matrixArray[i, j];
            if (j == matrixArray.GetLength(1) - 1)
            {
                WriteLine($"Сумма элементов строки {a + 1} равна -> {resultArr[a]}");
            }
        }

    int min = int.MaxValue;
    string SumMin = string.Empty;
    for (int i = 0; i < resultArr.Length; i++)      // вычисляем строку с min-ой суммой элементов в таблице
    {
        if (resultArr[i] < min)
        {
            min = resultArr[i];
            SumMin = $"{i + 1} строка";
        }
    }
    WriteLine();
    WriteLine($"Строка с наименьшей суммой элементов имеет -> {SumMin}");
    WriteLine();
}
