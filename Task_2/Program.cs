Console.Write("Введите первое число: ");
string? numberA = Console.ReadLine();
int a = Convert.ToInt32(numberA);
Console.Write("Введите второе число: ");
string? numberB = Console.ReadLine();
int b = Convert.ToInt32(numberB);


Console.Write("a=");
Console.Write(a + "; ");
Console.Write("b=");
Console.Write(b + " -> max = ");

if (a < b)
{
    Console.Write(b);
}
else
{
    Console.Write(a);
}