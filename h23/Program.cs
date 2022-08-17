// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int N = Convert.ToInt16(Console.ReadLine());

//N=Math.Abs(N);
int nach=1;
while (N>=nach)
{
  int sq=(nach*nach*nach);
Console.Write(sq);
Console.Write(" ");
nach++;
}