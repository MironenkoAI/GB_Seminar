// Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число от 1 до 7: ");
int week = Convert.ToInt32(Console.ReadLine());

if (week == 1)
    Console.WriteLine("Понедельник -> будний день");
else if (week == 2)
    Console.WriteLine("Вторник -> будний день");
else if (week == 3)
    Console.WriteLine("Среда -> будний день");
else if (week == 4)
    Console.WriteLine("Четверг -> будний день");
else if (week == 5)
    Console.WriteLine("Пятница -> будний день");
else if (week == 6)
    Console.WriteLine("Суббота -> выходной день");
else if (week == 7)
    Console.WriteLine("Воскресенье -> выходной день");
else
    Console.WriteLine("Вы ввели число вне диапазона. Попробуйте снова.");