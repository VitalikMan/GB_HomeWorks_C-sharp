// Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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


WriteLine("Выберете сортировку по возрастанию или по убыванию, введя значение (1 или -1), где:");
WriteLine("1 <- сортировка по убыванию;");
WriteLine("-1 <- сортировка по возрастанию;");
Write("Введите нужное значение (1 или -1): ");
bool isSortSelection = int.TryParse(ReadLine(), out int sortSelection);
if (!isSortSelection)
{
    Write("Ошибка! Вы ввели не число! Попробуйте еще раз");
    return;
}

WriteLine();
WriteLine("Полученная таблица: ");
PrintMatrixArray(matrixArray);
WriteLine();

if (sortSelection > 0)
{
    WriteLine("Отсортированная по убыванию по строкам таблица:");
    SortDescendingInRows(matrixArray);
    PrintMatrixArray(matrixArray);
}
else
{
    WriteLine("Отсортированная по возрастанию по строкам таблица:");
    SortDescendingInRows(matrixArray);
    PrintMatrixArray(matrixArray);
}




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

void SortDescendingInRows(int[,] sortMatrixArray)       // сортировка таблицы по убыванию или возрастанию по строкам
{
    for (int i = 0; i < sortMatrixArray.GetLength(0); i++)
    {
        for (int j = 0; j < sortMatrixArray.GetLength(1); j++)
        {
            for (int a = 0; a < sortMatrixArray.GetLength(1) - 1; a++)
            {
                if (sortMatrixArray[i, a] * sortSelection < sortMatrixArray[i, a + 1] * sortSelection)
                {
                    int temp = sortMatrixArray[i, a];
                    sortMatrixArray[i, a] = sortMatrixArray[i, a + 1];
                    sortMatrixArray[i, a + 1] = temp;
                }
            }
        }
    }
}
