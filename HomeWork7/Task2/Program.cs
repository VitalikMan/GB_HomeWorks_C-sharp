// Напишите программу реализующую метод,принимающий позиции элемента в двумерном массиве,
// и возвращающий значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1;7 -> такого элемента в массиве нет
// 1;1 -> 9

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

Write("Введите через пробел позицию искомого элемента в таблице, где первое значение это номер строки, а второе номер столбца: ");
string[] position = ReadLine()!.Split(new string[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries);
string positionInArray = ElementPositionCalculation(int.Parse(position[0]), int.Parse(position[1]), matrixArray);


WriteLine("Полученная таблица: ");
PrintMatrixArray(matrixArray);

WriteLine(positionInArray);



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
            Write($"{matrixArray[i, j],5} ");
        }
        WriteLine();
    }
}

string ElementPositionCalculation(int rowsPosition, int columnsPosition, int[,] matrixArray)    // метод поиска искомого элемента по позиции в таблице
{
    string resultPosition = string.Empty;
    for (int i = 0; i < matrixArray.GetLength(0); i++)
    {
        for (int j = 0; j < matrixArray.GetLength(1); j++)
        {
            if (rowsPosition <= matrixArray.GetLength(0) && columnsPosition <= matrixArray.GetLength(1))
            {
                if (rowsPosition > 0 && columnsPosition > 0)
                {
                    resultPosition = $"Искомый элемент в таблице равен -> " + matrixArray[rowsPosition - 1, columnsPosition - 1];
                }
                else { resultPosition = "Такого элемента в таблице нет!"; }
            }
            else { resultPosition = "Такого элемента в таблице нет!"; }
        }
    }
    return resultPosition;
}
