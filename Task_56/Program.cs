/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
суммой элементов: 1 строка */

int row = 5;
int column = 4;
int[,] numbers = new int[row, column];
FillMatrixRandomNumbers(numbers);
WriteMatrix(numbers);

int[] sums = new int[numbers.GetLength(0)];
Console.Write("Сумма элементов по строкам:  ");
int indexSum = 0;
for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        sums[indexSum] += numbers[i, j];
    }
    Console.Write(sums[indexSum] + "  ");
    indexSum++;
}
Console.WriteLine();
int min = sums[0];
int minRow = 0;
for (int i = 0; i < sums.Length; i++)
{
    if (sums[i] < min)
    {
        min = sums[i];
        minRow = i;
    }
}
Console.WriteLine($"Наименьшая сумма элементов {min} в строке {minRow}");
Console.WriteLine();

void FillMatrixRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void WriteMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "   ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
