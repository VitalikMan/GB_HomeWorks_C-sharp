// Напишите программу реализующую метод, который возвращает массив размером m×n,
// заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

using static System.Console;

Clear();

WriteLine("Для создания таблицы, введите значения, где:");
WriteLine("1) кол-во строк;");
WriteLine("2) кол-во столбцов;");
WriteLine("3) min-ый диапазон случайного значения;");
WriteLine("4) max-ый диапазон случайного значения;");
Write("Введите значения через пробел, для формирования таблицы: ");
string[] par = ReadLine()!.Split(new string[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries);
double[,] matrixArray = GetMatrixArray(int.Parse(par[0]), int.Parse(par[1]), Convert.ToDouble(par[2]), Convert.ToDouble(par[3]));

WriteLine("Полученная таблица: ");
PrintMatrixArray(matrixArray);



double[,] GetMatrixArray(int rows, int columns, double minValue, double maxValue)       // метод формирования таблицы
{
    double[,] resultArray = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i, j] = new Random().NextDouble() * (maxValue - minValue) + minValue;
        }
    }
    return resultArray;
}

void PrintMatrixArray(double[,] matrixArray)        // метод вывода заполненной таблицы
{
    for (int i = 0; i < matrixArray.GetLength(0); i++)
    {
        for (int j = 0; j < matrixArray.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                Write($"{matrixArray[i, j],5:f0} ");
            }
            else { Write($"{matrixArray[i, j],5:f1} "); }

        }
        WriteLine();
    }
}
