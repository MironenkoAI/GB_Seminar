/*Задача 29: Напишите программу, которая задаёт массив из N элементов
 и выводит их на экран. Вывод сделать отдельным методом.

5 -> [1, 2, 5, 7, 19]
3 -> [6, 1, 33]*/

Console.Write("Задайте длину массива N: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N <= 0)
{
    Console.WriteLine("Необходимо ввести число больше нуля. Попробуйте снова.");
}
else
{
    int[] array = new int[N];
    Method(array);
}

void Method(int[] array)
{
    Console.Write($"{N} -> [");

    for (int i = 0; i <= N - 1; i++)
    {
        array[i] = new Random().Next(1, 100); //ограничила диапазон, потому что генерирует большие числа
        if (i < N - 1)
        {
            Console.Write(array[i] + ", ");
        }
        else
            Console.Write(array[i] + "]");
    }
}
