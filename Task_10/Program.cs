// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число: ");
int ThreeDigitNumber = Convert.ToInt32(Console.ReadLine());

if (ThreeDigitNumber > 99 && ThreeDigitNumber < 1000)
{
    int DigitTwo = (ThreeDigitNumber / 10) % 10;
    Console.WriteLine(DigitTwo);
}
else if (ThreeDigitNumber > -1000 && ThreeDigitNumber < -99)
{
    int DigitTwo = (-ThreeDigitNumber / 10) % 10;
    Console.WriteLine(DigitTwo);
}

else
Console.WriteLine("Вы ввели число вне диапазона! Начните сначала.");