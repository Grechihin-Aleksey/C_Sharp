// 1. Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N при помощи рекурсии.
void Number(int num)
{
  if (num == 0) return;
  Number(num - 1);
  Console.Write($"{num} ");
}
Number(8);