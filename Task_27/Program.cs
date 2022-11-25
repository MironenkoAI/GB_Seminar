/*Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.Write("Введите положительное число: ");
int digit = Convert.ToInt32(Console.ReadLine());

if (digit < 0)
    Console.WriteLine("Вы ввели отрицательное число. Начните сначала.");
    //digit = -digit; для отрицательных

else
{
    Console.WriteLine($"{digit} -> {Method(digit)}");

    int Method(int digit)
    {
        int result = 0;
        while (digit != 0)
        {
            result = result + digit % 10;
            digit = digit / 10;
        }
        return result;
    }
}