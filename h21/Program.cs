// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
 //формула sqrt((X2-X1)^2 + (Y2-Y1)^2 + (Z2 - Z1)^2).
// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координату  точки A по X: ");
int xa = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите координату  точки A по Y: ");
int ya = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите координату  точки A по Z: ");
int za = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите координату  точки B по X: ");
int xb = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите координату  точки B по Y: ");
int yb = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите координату  точки B по Z: ");
int zb = Convert.ToInt16(Console.ReadLine());

double result=Math.Sqrt(Math.Pow(xb-xa,2)+Math.Pow(yb-ya,2)+Math.Pow(zb-za,2));
//result =Math.Round(result,2);
Console.WriteLine($"{result:f2}");