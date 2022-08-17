// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Write("Введите число: ");
int N = Convert.ToInt16(Console.ReadLine());

//N=Math.Abs(N);
int nach=1;
while (N>=nach)
{
  int sq=(nach*nach);
Console.Write(sq);
Console.Write(" ");
nach++;
}