/* Задача 65: Задайте значения M и N. Напишите программу, которая выведет все 
натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"

int number = ReadInt("Введите M: ");
int number2 = ReadInt("Введите N: ");

Console.WriteLine(NaturalNumber(number2, number));

int NaturalNumber(int m, int n)
{
    if (m == n)
        return m;
    else
    {
        Console.Write(NaturalNumber(m - 1, n) + ", ");
    }
    return m;
}
*/
int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}


/* Задача 67: Напишите программу, которая будет принимать 
на вход число и возвращать сумму его цифр.
453 -> 12 */

int number = ReadInt("Введите M: ");
int sum = 0;
Console.WriteLine(Sum(number));

int Sum(int num)
{
    if (num <= 0)
        return sum;
    else
    {
        sum += num % 10;
        Sum(num / 10);
    }
    return sum;
}


