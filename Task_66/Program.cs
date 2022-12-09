/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30  */

int start = ReadInt("Введите значение M: ");
int end = ReadInt("Введите значение N: ");

if (start > end)
{
    int temp = start;
    start = end;
    end = temp;
}

Console.WriteLine(NaturalNumber(start, end));

int sum = 0;
Console.WriteLine($"Сумма элементов равна: {Sum(start, end)}");

int Sum(int S, int E)
{
    if (S == E)
        sum = sum + E;
    else
    {
        sum = sum + S;
        Sum(S + 1, E);
    }
    return sum;
}


int NaturalNumber(int s, int e)
{
    if (s == e)
        return s;
    else
    {
        Console.Write(NaturalNumber(s, e - 1) + ", ");
    }
    return e;
}

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

