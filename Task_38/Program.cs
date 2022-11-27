/* Задача 38: Задайте массив вещественных чисел. Найдите разницу 
между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

Console.Write("Задайте длину массива: ");
int longArray = Convert.ToInt32(Console.ReadLine());

if (longArray <= 0)
{
    Console.WriteLine("Вы ввели невозможное значение. Попробуйте снова.");
}

else
{
    double[] array = new double[longArray];
    Console.Write("[");

    for (int i = 0; i < longArray; i++)
    {                            //ограничила диапазон, для легкости счета
        array[i] = Math.Round(new Random().Next(-100, 100) + new Random().NextDouble(), 2);
        if (i == longArray - 1)
        {
            Console.WriteLine(array[i] + "]");
        }
        else Console.Write(array[i] + "; ");
    }

    double min = array[0];
    double max = array[0];

    for (int i = 1; i < longArray; i++)
    {
        if (min > array[i]) min = array[i];
        if (max < array[i]) max = array[i];
    }

    Console.WriteLine($"минимальный элемент: {min}");
    Console.WriteLine($"максимальный элемент: {max}");
    Console.WriteLine($"разница между элементами = {max - min}");
}
