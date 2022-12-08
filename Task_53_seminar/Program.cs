/* Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет
 местами первую и последнюю строку массива.*/

int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] nambers = new int[rows, columns];
FillMatrixRandomNumbers(nambers);
WriteMatrix(nambers);


for (int j = 0; j < nambers.GetLength(1); j++)
{
    int i = 0;
    int temp = nambers[0, j];
    nambers[0, j] = nambers[nambers.GetLength(0)-1,j];
    nambers[nambers.GetLength(0)-1,j]=temp;
}
WriteMatrix(nambers);



/* Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет
 строки на столбцы. В случае, если это невозможно, программа должна вывести
 сообщение для пользователя. */

int row = ReadInt("Введите количество строк: ");
int column = ReadInt("Введите количество столбцов: ");
if (row!=column)
{
    Console.WriteLine("Операция невозможна!");
    return;
}
int[,] numbers = new int[row, column];
FillMatrixRandomNumbers(numbers);
WriteMatrix(numbers);

int[,] numbers2 = new int[row, column];


for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers2[i,j] = numbers[j,i];
        }
    }
WriteMatrix(numbers2);




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

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
