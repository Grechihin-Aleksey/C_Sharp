// 2. Задайте значения M и N. Напишите программу, которая
// рекурсивно выведет все натуральные числа в промежутке от M до N.
void Number(int max, int min) 
{
  if (min > max) return;
  Number(max - 1, min);
  Console.Write($"{max} ");
}
Number(7, 2);
