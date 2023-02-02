// ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

using static System.Console;

Clear();

WriteLine("Для создания трехмерной фигуры, введите значения, где:");
WriteLine("    1) высота фигуры;");
WriteLine("    2) длина фигуры;");
WriteLine("    3) ширина фигуры;");
WriteLine("    4) min-ый диапазон случайного значения;");
WriteLine("    5) max-ый диапазон случайного значения;");
WriteLine();
Write("Введите значения через пробел, для формирования фигуры: ");
string[] par = ReadLine()!.Split(new string[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries);
int[,,] matrixArray = GetMatrixArray(int.Parse(par[0]), int.Parse(par[1]), int.Parse(par[2]), Convert.ToInt32(par[3]), Convert.ToInt32(par[4]));

WriteLine();
WriteLine("Полученная фигура со значениями: ");
PrintMatrixArray(matrixArray);
WriteLine();
PrintValueAndIndexArray(matrixArray);
WriteLine();




int[,,] GetMatrixArray(int heightFigure, int lengthFigure, int widthFigure, int minValue, int maxValue)    // метод формирования фигуры
{
    int size = minValue * maxValue;
    int[] arrayValue = new int[size];
    int[,,] resultArray = new int[heightFigure, lengthFigure, widthFigure];
    for (int a = 0, w = 10; w < 100; a++, w++)      // создание одномерного массива с неповторяющимися значениями
    {
        arrayValue[a] = w;
    }

    int b = 0;
    for (int k = 0; k < heightFigure; k++)      // присвоение значений с одномерного массива в трехмерный массив
    {
        for (int i = 0; i < lengthFigure; i++)
        {
            for (int j = 0; j < widthFigure; j++)
            {
                resultArray[k, i, j] = arrayValue[b];
                b++;
            }
        }
    }

    Random rnd = new Random();
    for (int k = 0; k < heightFigure; k++)      // разброс значений в случайном порядке в массиве
    {
        for (int i = 0; i < lengthFigure; i++)
        {
            for (int j = 0; j < widthFigure; j++)
            {
                int index1 = heightFigure;
                int index2 = lengthFigure;
                int index3 = widthFigure;
                int num1 = rnd.Next(0, index1);
                int num2 = rnd.Next(0, index2);
                int num3 = rnd.Next(0, index3);
                int temp = resultArray[k, i, j];
                resultArray[k, i, j] = resultArray[num1, num2, num3];
                resultArray[num1, num2, num3] = temp;
            }
        }
    }
    return resultArray;
}

void PrintMatrixArray(int[,,] matrixArray)       // метод вывода фигуры заполненной значениями
{
    for (int k = 0; k < matrixArray.GetLength(0); k++)
    {
        WriteLine($"{k + 1} часть фигуры:");
        for (int i = 0; i < matrixArray.GetLength(1); i++)
        {
            for (int j = 0; j < matrixArray.GetLength(2); j++)
            {
                Write($"{matrixArray[k, i, j],5}");
            }
            WriteLine();
        }
        WriteLine();
    }
}

void PrintValueAndIndexArray(int[,,] matrixArray)       // метод вывода значения и его индекса в массиве
{
    for (int k = 0; k < matrixArray.GetLength(0); k++)
    {
        WriteLine($"{k + 1} часть фигуры:");
        for (int i = 0; i < matrixArray.GetLength(1); i++)
        {
            for (int j = 0; j < matrixArray.GetLength(2); j++)
            {
                WriteLine($"{matrixArray[k, i, j]} ({k}, {i}, {j}) ");
            }
            WriteLine();
        }
        WriteLine();
    }
}
