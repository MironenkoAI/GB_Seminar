/* Задача 64: Задайте значение N. Напишите программу, которая 
выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

int start = ReadInt("Задайте число N больше 0: ");
int end = 1;

Console.WriteLine(NaturalNumber(start, end));

int NaturalNumber(int s, int e)
{
    if (s == e)
        return s;
    else
    {
        Console.Write(NaturalNumber(s, e + 1) + ", ");
    }
    return e;
}

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}
