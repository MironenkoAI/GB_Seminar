/* Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы 
каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

int x = ReadInt("Введите x трехмерного массива: ");
int y = ReadInt("Введите y трехмерного массива: ");
int z = ReadInt("Введите z трехмерного массива: ");

if (x * y * z > 90 || x * y * z < 1)
{
    Console.WriteLine("Массив выходит за пределы двузначных чисел или вы ввели недопустимое число");
    return;
}

int[,,] matrix3D = new int[x, y, z];
int start = 10;

for (int i = 0; i < matrix3D.GetLength(0); i++)
{
    for (int j = 0; j < matrix3D.GetLength(1); j++)
    {
        for (int k = 0; k < matrix3D.GetLength(2); k++)
        {
            matrix3D[i, j, k] = start++;
            Console.Write($"{matrix3D[i, j, k]}[{i}, {j}, {k}]   ");
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

