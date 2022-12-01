/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

double b1 = ReadInt("Введите значение ординаты b1 для прямой a: ");
double k1 = ReadInt("Введите значение углового коэффициента k1 для прямой a: ");
double b2 = ReadInt("Введите значение ординаты b2 для прямой b: ");
double k2 = ReadInt("Введите значение углового коэффициента k2 для прямой b: ");


if (k1 == k2)
{
    Console.WriteLine("Прямые параллельны.");
}
else
{
    double xA = Math.Round((b1-b2)/(k2-k1), 2);
    double yA = Math.Round(k1 * xA + b1, 2);

    Console.WriteLine($"Точка пересечения имеет координаты: A({xA}; {yA})");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}