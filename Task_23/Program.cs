/* Задача 23: Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/


Console.Write("Введите любое число больше нуля: ");
int number = Convert.ToInt32(Console.ReadLine());

int index = 1;

while (index <= number)
{
    if (index == number)
    {
        Console.Write(index * index * index);
    }
    else
    {
        Console.Write(index * index * index + ", ");
    }
    index++;
}

if (number <= 0)
{
    Console.Write("Вы ввели число вне диапазона! Начните сначала.");
}