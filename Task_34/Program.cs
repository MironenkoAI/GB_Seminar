/* Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет количество
чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

Console.Write("Задайте длину массива: ");
int longArray = Convert.ToInt32(Console.ReadLine());

if (longArray <= 0)
{
    Console.WriteLine("Вы ввели невозможное значение. Попробуйте снова.");
}

else
{
    int[] array = new int[longArray];
    Console.Write("[");

    for (int i = 0; i < longArray; i++)
    {
        array[i] = new Random().Next(100, 999);
        if (i == longArray - 1)
        {
            Console.Write(array[i] + "] -> ");
        }
        else Console.Write(array[i] + ", ");
    }

    int count = 0;
    
    for (int i = 0; i < longArray; i++)
    {
        if (array[i] % 2 == 0)
        count++;
    }
    Console.Write($"в массиве четных чисел: {count}");
}

