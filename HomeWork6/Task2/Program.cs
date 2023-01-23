// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Преобразование формулы, для нахождения координатных точек:
// y = k1 * x + b1
// y = k2 * x + b2
// k1 * x + b1 = k2 * x + b2
// (k1 - k2) * x = b2 - b1
// x = (b2 - b1) / (k1 - k2)
// y = k1 * x + b1 || y = k2 * x + b2


using static System.Console;

Clear();

WriteLine("Введите значения b1 и k1:");
Write("b1 = ");
double b1 = int.Parse(ReadLine()!);
Write("k1 = ");
double k1 = int.Parse(ReadLine()!);

WriteLine("Введите значения b2 и k2:");
Write("b2 = ");
double b2 = int.Parse(ReadLine()!);
Write("k2 = ");
double k2 = int.Parse(ReadLine()!);

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

WriteLine($"Точки пересечения двух прямых: ({x}; {y})");
