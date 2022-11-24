/* Задача 25: Напишите цикл, который принимает на вход 
два числа (A и B) и возводит число A в натуральную степень B.
Без использования функции Math.Pow.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

int numA = ReadInt("Введите первое число: ");
int numB = ReadInt("Введите второе число: ");

int result = numA;
for (int count = 1; count < numB; count++)
{
    int temp = result * numA;
    result = temp;
}
Console.WriteLine($"{numA}, {numB} -> {result}");

int ReadInt(string message) 
{     
    Console.Write(message);     
    return Convert.ToInt32(Console.ReadLine()); 
}