// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("x A = ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y A = ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z A = ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("x B = ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y B = ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z B = ");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((x1-x2),2)
                         +Math.Pow((y1-y2),2)
                         +Math.Pow((z1-z2),2));

Console.WriteLine("длина отрезка = " + result);