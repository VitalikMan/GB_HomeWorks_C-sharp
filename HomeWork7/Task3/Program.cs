// Напишите программу реализующую методы, формирования двумерного массива и массива средних арифметических значений каждого столбца.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using static System.Console;

Clear();

WriteLine("Для создания таблицы, введите значения, где:");
WriteLine("1) кол-во строк;");
WriteLine("2) кол-во столбцов;");
WriteLine("3) min-ый диапазон случайного значения;");
WriteLine("4) max-ый диапазон случайного значения;");
Write("Введите значения через пробел, для формирования таблицы: ");
string[] par = ReadLine()!.Split(new string[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries);
int[,] matrixArray = GetMatrixArray(int.Parse(par[0]), int.Parse(par[1]), Convert.ToInt32(par[2]), Convert.ToInt32(par[3]));


WriteLine("Полученная таблица: ");
PrintMatrixArray(matrixArray);

ArithmeticMeanOfEachTableColumn(matrixArray);




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

void ArithmeticMeanOfEachTableColumn(int[,] matrixArray)        // метод вычисления среднее арифметическое значение каждого столбца
{
    double[] result = new double[matrixArray.GetLength(1)];
    for (int j = 0; j < matrixArray.GetLength(1); j++)
    {
        for (int i = 0; i < matrixArray.GetLength(0); i++)
        {
            result[j] += matrixArray[i, j];
        }
        Write($"{result[j] /= matrixArray.GetLength(0),6:f2}");
    }
}
