// Задача 2: Напишите программу, которая принимает на вход два числа 
//и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
string? numberA = Console.ReadLine();
int a = Convert.ToInt32(numberA);
Console.Write("Введите второе число: ");
string? numberB = Console.ReadLine();
int b = Convert.ToInt32(numberB);


Console.Write("a=");
Console.Write(a + "; ");
Console.Write("b=");
Console.Write(b + " -> ");

if (a < b)
{
    Console.Write("max = " + b + "; min = " + a + ".");
}
else
{
    Console.Write("max = " + a + "; min = " + b);
}