// Задача 4: Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число: ");
string? numberA = Console.ReadLine();
int a = Convert.ToInt32(numberA);
Console.Write("Введите второе число: ");
string? numberB = Console.ReadLine();
int b = Convert.ToInt32(numberB);
Console.Write("Введите третье число: ");
string? numberC = Console.ReadLine();
int c = Convert.ToInt32(numberC);


Console.Write("a=");
Console.Write(a + "; ");
Console.Write("b=");
Console.Write(b + "; ");
Console.Write("c=");
Console.Write(c + " -> max = ");


if(a > b)
{
    if(a > c)
    {
        Console.Write(a);
    }
    else
    {
        Console.Write(c);
    }
}
else if(b > c)
{
    Console.Write(b);
}
else 
{
    Console.Write(c);
}