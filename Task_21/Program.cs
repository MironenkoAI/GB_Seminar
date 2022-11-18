/* Задача 21: Напишите программу, которая принимает на вход координаты 
двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

int aX = ReadInt("Введите координату X точки A: "); 
int aY = ReadInt("Введите координату Y точки A: ");
int aZ = ReadInt("Введите координату Z точки A: ");
int bX = ReadInt("Введите координату X точки B: "); 
int bY = ReadInt("Введите координату Y точки B: "); 
int bZ = ReadInt("Введите координату Z точки B: "); 

int sqrX = (aX - bX) * (aX - bX); 
int sqrY = (aY - bY) * (aY - bY); 
int sqrZ = (aZ - bZ) * (aZ - bZ);

double distance = Math.Sqrt(sqrX + sqrY + sqrZ); 
Console.WriteLine(distance);  

int ReadInt(string message) 
{     
    Console.Write(message);     
    return Convert.ToInt32(Console.ReadLine()); 
}