// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number > -1000 && Number < -99)
{
    Console.WriteLine(-Number % 10);
}
else if (Number > -100 && Number < 100)
{
    Console.WriteLine("В числе третьей цифры нет");
}
else if (Number > 99 && Number < 1000)
{
    Console.WriteLine(Number % 10);
}
while (Number > 999)
{
    Number = Number / 10;
    if (Number < 1000)
    {
        Console.WriteLine(Number % 10);
    }
}
while (Number < -999)
{
    Number = Number / 10;
    if (Number > -1000)
    {
        Console.WriteLine(-Number % 10);
    }
}