/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

int matrix = ReadInt("Введите размер матрицы: ");
int[,] numbers = new int[matrix, matrix];
int start = 1;
int i = 0;
int j = 0;

while (start <= numbers.Length)
{
    numbers[i, j] = start++;
    if (i <= j + 1 && i + j < matrix - 1)
        j++;
    else if (i < j && i + j >= matrix - 1)
        i++;
    else if (i >= j && i + j > matrix - 1)
        j--;
    else
        i--;
}
WriteMatrix(numbers);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
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