// Задача 20: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21


Console.Write("Введите координату  точки А по X: ");
int ax = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите координату  точки A по Y: ");
int ay = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите координату  точки B по X: ");
int bx = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите координату  точки B по Y: ");
int by = Convert.ToInt16(Console.ReadLine());

double result=Math.Sqrt(Math.Pow(bx-ax,2)+Math.Pow(by-ay,2));
//result =Math.Round(result,2);
Console.WriteLine($"{result:f2}");


