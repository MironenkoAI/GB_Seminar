// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите любое целое число: ");
string? number = Console.ReadLine();
int x = Convert.ToInt32(number);

if(x%2==0)
{
    Console.Write(x + " - четное число");
}
else
{
    Console.Write(x + " - нечетное число");
}
