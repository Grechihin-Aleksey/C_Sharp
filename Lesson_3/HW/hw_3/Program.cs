// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.WriteLine("Введите число: ");
int count = 1;
void function(int item)
{
  while (count <= Math.Abs(item))
  {
    Console.WriteLine(Math.Pow(count, 3));
    count++;
  }
}

function(int.Parse(Console.ReadLine()!));

