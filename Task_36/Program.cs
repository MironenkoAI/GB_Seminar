/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

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
        array[i] = new Random().Next(-99, 99); //ограничила диапазон, для легкости счета
        if (i == longArray - 1)
        {
            Console.Write(array[i] + "] -> ");
        }
        else Console.Write(array[i] + ", ");
    }

    int sum = 0;
    
    for (int i = 1; i < longArray; i+=2)
    {
        sum = sum + array[i];
    }
    Console.Write($"сумма чисел с нечетным индексом: {sum}");
}


