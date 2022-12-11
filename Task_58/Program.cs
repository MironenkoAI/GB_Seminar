/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

int matrix = ReadInt("Введите размер матрицы: ");

int[,] numbers1 = new int[matrix, matrix];
FillMatrixRandomNumbers(numbers1);
WriteMatrix(numbers1);
Console.WriteLine("--------");

int[,] numbers2 = new int[matrix, matrix];
FillMatrixRandomNumbers(numbers2);
WriteMatrix(numbers2);

int[,] resultNumbers = new int[matrix, matrix];

for (int j = 0; j < resultNumbers.GetLength(1); j++)
{
    for (int i = 0; i < resultNumbers.GetLength(0); i++)
    {
        for (int k = 0; k < numbers1.GetLength(0); k++)
        {
            resultNumbers[i, j] += numbers1[i, k] * numbers2[k, j];
        }
    }
}
Console.WriteLine("Результирующая матрица:");
WriteMatrix(resultNumbers);


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
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


